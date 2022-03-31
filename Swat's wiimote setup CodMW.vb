// Wiimote script for call of duty modern warfare
// Requires a wii sensor bar

var.ButtonFreezeTime = 250ms
var.PointerBump = KeepDown(Pressed(wiimote.A),var.ButtonFreezeTime) or KeepDown(Pressed(wiimote.B),var.ButtonFreezeTime)
Wiimote.Led1 = true

// Mouse movement
if wiimote.PointerVisible but not var.PointerBump then
  mouse.x = wiimote.PointerX
  mouse.y = wiimote.PointerY
end if

// Mouse Buttons
mouse.LeftButton = Wiimote.B and KeepDown(Wiimote.PointerVisible,0.5s)
mouse.RightButton = Nunchuk1.Z and KeepDown(Wiimote.PointerVisible,0.5s)

// General
Escape = Wiimote.Home and KeepDown(Wiimote.PointerVisible,0.5s)
Tab = Wiimote1.One and KeepDown(Wiimote.PointerVisible,0.5s)

// Movement
Shift = Wiimote.A and KeepDown(Wiimote.PointerVisible,0.5s)
WASD = nunchuk1.Joy
Space = Wiimote1.Up and KeepDown(Wiimote.PointerVisible,0.5s)
Control = Nunchuck.C and KeepDown(Wiimote.PointerVisible,0.5s)

// Weapons
R = Nunchuk.SwingDown and KeepDown(Wiimote.PointerVisible,0.5s)


// Dpad
F = Wiimote1.Left and KeepDown(Wiimote.PointerVisible,0.5s)
V = Wiimote1.Stabbing and KeepDown(Wiimote.PointerVisible,0.5s)
E = Wiimote1.Right and KeepDown(Wiimote.PointerVisible,0.5s)
Mouse.WheelDown = Wiimote1.Down and KeepDown(Wiimote.PointerVisible,0.5s)

// Voice
P = Wiimote1.Two and KeepDown(Wiimote.PointerVisible,0.5s)

// Equipment
Four = Wiimote1.Minus and KeepDown(Wiimote.PointerVisible,0.5s)
G = Wiimote1.Plus and KeepDown(Wiimote.PointerVisible,0.5s)
