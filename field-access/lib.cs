function SimObject::getField(%this, %name)
{
    if (%name $= "")
        return "";

    switch (stripos("_abcdefghijklmnopqrstuvwxyz", getSubStr(%name, 0, 1)))
    {
        case  0: return %this._[getSubStr(%name, 1, strlen(%name))];
        case  1: return %this.a[getSubStr(%name, 1, strlen(%name))];
        case  2: return %this.b[getSubStr(%name, 1, strlen(%name))];
        case  3: return %this.c[getSubStr(%name, 1, strlen(%name))];
        case  4: return %this.d[getSubStr(%name, 1, strlen(%name))];
        case  5: return %this.e[getSubStr(%name, 1, strlen(%name))];
        case  6: return %this.f[getSubStr(%name, 1, strlen(%name))];
        case  7: return %this.g[getSubStr(%name, 1, strlen(%name))];
        case  8: return %this.h[getSubStr(%name, 1, strlen(%name))];
        case  9: return %this.i[getSubStr(%name, 1, strlen(%name))];
        case 10: return %this.j[getSubStr(%name, 1, strlen(%name))];
        case 11: return %this.k[getSubStr(%name, 1, strlen(%name))];
        case 12: return %this.l[getSubStr(%name, 1, strlen(%name))];
        case 13: return %this.m[getSubStr(%name, 1, strlen(%name))];
        case 14: return %this.n[getSubStr(%name, 1, strlen(%name))];
        case 15: return %this.o[getSubStr(%name, 1, strlen(%name))];
        case 16: return %this.p[getSubStr(%name, 1, strlen(%name))];
        case 17: return %this.q[getSubStr(%name, 1, strlen(%name))];
        case 18: return %this.r[getSubStr(%name, 1, strlen(%name))];
        case 19: return %this.s[getSubStr(%name, 1, strlen(%name))];
        case 20: return %this.t[getSubStr(%name, 1, strlen(%name))];
        case 21: return %this.u[getSubStr(%name, 1, strlen(%name))];
        case 22: return %this.v[getSubStr(%name, 1, strlen(%name))];
        case 23: return %this.w[getSubStr(%name, 1, strlen(%name))];
        case 24: return %this.x[getSubStr(%name, 1, strlen(%name))];
        case 25: return %this.y[getSubStr(%name, 1, strlen(%name))];
        case 26: return %this.z[getSubStr(%name, 1, strlen(%name))];
    }

    return "";
}

function SimObject::setField(%this, %name, %value)
{
    switch (stripos("_abcdefghijklmnopqrstuvwxyz", getSubStr(%name, 0, 1)))
    {
        case  0: %this._[getSubStr(%name, 1, strlen(%name))] = %value;
        case  1: %this.a[getSubStr(%name, 1, strlen(%name))] = %value;
        case  2: %this.b[getSubStr(%name, 1, strlen(%name))] = %value;
        case  3: %this.c[getSubStr(%name, 1, strlen(%name))] = %value;
        case  4: %this.d[getSubStr(%name, 1, strlen(%name))] = %value;
        case  5: %this.e[getSubStr(%name, 1, strlen(%name))] = %value;
        case  6: %this.f[getSubStr(%name, 1, strlen(%name))] = %value;
        case  7: %this.g[getSubStr(%name, 1, strlen(%name))] = %value;
        case  8: %this.h[getSubStr(%name, 1, strlen(%name))] = %value;
        case  9: %this.i[getSubStr(%name, 1, strlen(%name))] = %value;
        case 10: %this.j[getSubStr(%name, 1, strlen(%name))] = %value;
        case 11: %this.k[getSubStr(%name, 1, strlen(%name))] = %value;
        case 12: %this.l[getSubStr(%name, 1, strlen(%name))] = %value;
        case 13: %this.m[getSubStr(%name, 1, strlen(%name))] = %value;
        case 14: %this.n[getSubStr(%name, 1, strlen(%name))] = %value;
        case 15: %this.o[getSubStr(%name, 1, strlen(%name))] = %value;
        case 16: %this.p[getSubStr(%name, 1, strlen(%name))] = %value;
        case 17: %this.q[getSubStr(%name, 1, strlen(%name))] = %value;
        case 18: %this.r[getSubStr(%name, 1, strlen(%name))] = %value;
        case 19: %this.s[getSubStr(%name, 1, strlen(%name))] = %value;
        case 20: %this.t[getSubStr(%name, 1, strlen(%name))] = %value;
        case 21: %this.u[getSubStr(%name, 1, strlen(%name))] = %value;
        case 22: %this.v[getSubStr(%name, 1, strlen(%name))] = %value;
        case 23: %this.w[getSubStr(%name, 1, strlen(%name))] = %value;
        case 24: %this.x[getSubStr(%name, 1, strlen(%name))] = %value;
        case 25: %this.y[getSubStr(%name, 1, strlen(%name))] = %value;
        case 26: %this.z[getSubStr(%name, 1, strlen(%name))] = %value;
    }

    return %value;
}
