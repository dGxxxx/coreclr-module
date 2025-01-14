namespace AltV.Net.Data;

/// <summary>
/// Represents the response to a weapon damage event, indicating whether the damage is processed and the amount of damage.
/// </summary>
public record WeaponDamageResponse(bool Cancel, uint? Damage)
{
    /// <summary>
    /// Implicit conversion from a boolean value to <see cref="WeaponDamageResponse"/>.
    /// Sets <see cref="Cancel"/> to the specified value and <see cref="Damage"/> to null.
    /// </summary>
    /// <param name="cancel">Indicates whether the damage is processed.</param>
    public static implicit operator WeaponDamageResponse(bool cancel) => new(cancel, null);

    /// <summary>
    /// Implicit conversion from an uint value to <see cref="WeaponDamageResponse"/>.
    /// Sets <see cref="Cancel"/> to true and <see cref="Damage"/> to the specified value.
    /// </summary>
    /// <param name="damage">The amount of damage.</param>
    public static implicit operator WeaponDamageResponse(uint damage) => new(false, damage);
}
