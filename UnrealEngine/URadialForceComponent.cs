using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001063 RID: 4195
	[UnrealObjectPath("/Script/Engine.RadialForceComponent")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class URadialForceComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EEA7 RID: 61095 RVA: 0x00162053 File Offset: 0x00160253
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URadialForceComponent._ClassPtr;
		}

		// Token: 0x0600EEA8 RID: 61096 RVA: 0x00162060 File Offset: 0x00160260
		public URadialForceComponent() : this(BuiltinUtils.AllocNativeUObject(URadialForceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EEA9 RID: 61097 RVA: 0x00162088 File Offset: 0x00160288
		[NullableContext(1)]
		public URadialForceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URadialForceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600EEAA RID: 61098 RVA: 0x001620BB File Offset: 0x001602BB
		// (set) Token: 0x0600EEAB RID: 61099 RVA: 0x001620CB File Offset: 0x001602CB
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600EEAC RID: 61100 RVA: 0x001620DC File Offset: 0x001602DC
		// (set) Token: 0x0600EEAD RID: 61101 RVA: 0x001620F0 File Offset: 0x001602F0
		public unsafe TEnumAsByte<ERadialImpulseFalloff> Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_Falloff) = value;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600EEAE RID: 61102 RVA: 0x00162105 File Offset: 0x00160305
		// (set) Token: 0x0600EEAF RID: 61103 RVA: 0x00162115 File Offset: 0x00160315
		public unsafe float ImpulseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_ImpulseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_ImpulseStrength) = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600EEB0 RID: 61104 RVA: 0x00162126 File Offset: 0x00160326
		// (set) Token: 0x0600EEB1 RID: 61105 RVA: 0x0016213F File Offset: 0x0016033F
		public unsafe bool bImpulseVelChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_bImpulseVelChange) & URadialForceComponent.__PropertyMask_bImpulseVelChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_bImpulseVelChange) = ((*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_bImpulseVelChange) & ~URadialForceComponent.__PropertyMask_bImpulseVelChange) | (value ? URadialForceComponent.__PropertyMask_bImpulseVelChange : 0));
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600EEB2 RID: 61106 RVA: 0x0016216F File Offset: 0x0016036F
		// (set) Token: 0x0600EEB3 RID: 61107 RVA: 0x00162188 File Offset: 0x00160388
		public unsafe bool bIgnoreOwningActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_bIgnoreOwningActor) & URadialForceComponent.__PropertyMask_bIgnoreOwningActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_bIgnoreOwningActor) = ((*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_bIgnoreOwningActor) & ~URadialForceComponent.__PropertyMask_bIgnoreOwningActor) | (value ? URadialForceComponent.__PropertyMask_bIgnoreOwningActor : 0));
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600EEB4 RID: 61108 RVA: 0x001621B8 File Offset: 0x001603B8
		// (set) Token: 0x0600EEB5 RID: 61109 RVA: 0x001621C8 File Offset: 0x001603C8
		public unsafe float ForceStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_ForceStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_ForceStrength) = value;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600EEB6 RID: 61110 RVA: 0x001621D9 File Offset: 0x001603D9
		// (set) Token: 0x0600EEB7 RID: 61111 RVA: 0x001621E9 File Offset: 0x001603E9
		public unsafe float DestructibleDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_DestructibleDamage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_DestructibleDamage) = value;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600EEB8 RID: 61112 RVA: 0x001621FC File Offset: 0x001603FC
		// (set) Token: 0x0600EEB9 RID: 61113 RVA: 0x00162235 File Offset: 0x00160435
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypesToAffect
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._ObjectTypesToAffect) == null)
				{
					result = (this._ObjectTypesToAffect = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)URadialForceComponent.__PropertyOffset_ObjectTypesToAffect, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ObjectTypesToAffect.CopyAssign(value);
			}
		}

		// Token: 0x0600EEBA RID: 61114 RVA: 0x00162243 File Offset: 0x00160443
		public void RemoveObjectTypeToAffect(EObjectTypeQuery ObjectType)
		{
			URadialForceComponent.__RemoveObjectTypeToAffect_Internal(base.NativePtr, ObjectType);
		}

		// Token: 0x0600EEBB RID: 61115 RVA: 0x00162256 File Offset: 0x00160456
		public void FireImpulse()
		{
			URadialForceComponent.__FireImpulse_Internal(base.NativePtr);
		}

		// Token: 0x0600EEBC RID: 61116 RVA: 0x00162263 File Offset: 0x00160463
		public void AddObjectTypeToAffect(EObjectTypeQuery ObjectType)
		{
			URadialForceComponent.__AddObjectTypeToAffect_Internal(base.NativePtr, ObjectType);
		}

		// Token: 0x0600EEBD RID: 61117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveObjectTypeToAffect_Internal(IntPtr @this, TEnumAsByte<EObjectTypeQuery> ObjectType);

		// Token: 0x0600EEBE RID: 61118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FireImpulse_Internal(IntPtr @this);

		// Token: 0x0600EEBF RID: 61119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddObjectTypeToAffect_Internal(IntPtr @this, TEnumAsByte<EObjectTypeQuery> ObjectType);

		// Token: 0x0600EEC0 RID: 61120 RVA: 0x00162276 File Offset: 0x00160476
		static URadialForceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RadialForceComponent");
		}

		// Token: 0x0600EEC1 RID: 61121 RVA: 0x00162284 File Offset: 0x00160484
		protected URadialForceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400812C RID: 33068
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RadialForceComponent";

		// Token: 0x0400812D RID: 33069
		private static IntPtr _ClassPtr;

		// Token: 0x0400812E RID: 33070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400812F RID: 33071
		internal static int __PropertyOffset_Radius;

		// Token: 0x04008130 RID: 33072
		internal static int __PropertyOffset_Falloff;

		// Token: 0x04008131 RID: 33073
		internal static int __PropertyOffset_ImpulseStrength;

		// Token: 0x04008132 RID: 33074
		internal static int __PropertyOffset_bImpulseVelChange;

		// Token: 0x04008133 RID: 33075
		internal static byte __PropertyMask_bImpulseVelChange;

		// Token: 0x04008134 RID: 33076
		internal static int __PropertyOffset_bIgnoreOwningActor;

		// Token: 0x04008135 RID: 33077
		internal static byte __PropertyMask_bIgnoreOwningActor;

		// Token: 0x04008136 RID: 33078
		internal static int __PropertyOffset_ForceStrength;

		// Token: 0x04008137 RID: 33079
		internal static int __PropertyOffset_DestructibleDamage;

		// Token: 0x04008138 RID: 33080
		internal static int __PropertyOffset_ObjectTypesToAffect;

		// Token: 0x04008139 RID: 33081
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypesToAffect;
	}
}
