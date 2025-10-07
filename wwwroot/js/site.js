// Slime ball canvas animation (simple springy metaball)
(function () {
    const canvas = document.getElementById('slime');
    if (!canvas) return;
    const ctx = canvas.getContext('2d');

    const DPR = Math.max(1, Math.min(2, window.devicePixelRatio || 1));
    let W, H;
    function resize() {
        W = canvas.clientWidth = window.innerWidth;
        H = canvas.clientHeight = window.innerHeight;
        canvas.width = W * DPR;
        canvas.height = H * DPR;
        ctx.setTransform(DPR, 0, 0, DPR, 0, 0);
    }
    resize();
    window.addEventListener('resize', resize);

    // detect page: login has stronger motion
    const isLogin = document.body.classList.contains('theme-login');

    // physics params
    const ball = {
        x: W * 0.25,
        y: H * 0.25,
        vx: 0, vy: 0,
        r: isLogin ? 90 : 70,
    };
    const target = { x: W * 0.6, y: H * 0.4 };
    let t = 0;

    function step() {
        t += 0.016;
        const k = isLogin ? 0.012 : 0.008;     // spring stiffness
        const d = isLogin ? 0.86 : 0.90;       // damping
        // move target in a Lissajous curve
        const ampX = isLogin ? W * 0.30 : W * 0.20;
        const ampY = isLogin ? H * 0.20 : H * 0.14;
        target.x = W * 0.5 + Math.sin(t * 0.9) * ampX;
        target.y = H * 0.45 + Math.cos(t * 1.2) * ampY;

        // spring to target
        const ax = (target.x - ball.x) * k;
        const ay = (target.y - ball.y) * k;
        ball.vx = (ball.vx + ax) * d;
        ball.vy = (ball.vy + ay) * d;
        ball.x += ball.vx;
        ball.y += ball.vy;

        // draw
        ctx.clearRect(0, 0, W, H);

        // soft gradient background dots
        for (let i = 0; i < (isLogin ? 3 : 2); i++) {
            const px = (i * 0.33 + 0.2 + Math.sin(t * (0.4 + i * 0.1)) * 0.05) * W;
            const py = (0.15 + i * 0.25 + Math.cos(t * (0.5 + i * 0.1)) * 0.04) * H;
            const grad = ctx.createRadialGradient(px, py, 0, px, py, isLogin ? 380 : 300);
            grad.addColorStop(0, 'rgba(124,58,237,0.10)');
            grad.addColorStop(1, 'rgba(255,255,255,0.0)');
            ctx.fillStyle = grad;
            ctx.beginPath();
            ctx.arc(px, py, isLogin ? 380 : 300, 0, Math.PI * 2);
            ctx.fill();
        }

        // slime body (metaball-ish by scaling y to create squash)
        const squash = 1 + Math.min(0.25, Math.hypot(ball.vx, ball.vy) / 50);
        ctx.save();
        ctx.translate(ball.x, ball.y);
        ctx.scale(1 / squash, squash); // conserve area visually
        const grad2 = ctx.createRadialGradient(0, 0, 10, 0, 0, ball.r);
        grad2.addColorStop(0, isLogin ? 'rgba(124,58,237,0.35)' : 'rgba(124,58,237,0.25)');
        grad2.addColorStop(1, 'rgba(34,211,238,0.15)');
        ctx.fillStyle = grad2;
        ctx.beginPath();
        ctx.arc(0, 0, ball.r, 0, Math.PI * 2);
        ctx.fill();
        ctx.restore();

        requestAnimationFrame(step);
    }
    step();
})();
