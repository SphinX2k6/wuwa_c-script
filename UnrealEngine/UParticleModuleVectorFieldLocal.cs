using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB4 RID: 4020
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldLocal")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleVectorFieldLocal : UParticleModuleVectorFieldBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D87C RID: 55420 RVA: 0x0013F681 File Offset: 0x0013D881
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldLocal._ClassPtr;
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x0013F690 File Offset: 0x0013D890
		public UParticleModuleVectorFieldLocal() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldLocal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D87E RID: 55422 RVA: 0x0013F6B8 File Offset: 0x0013D8B8
		[NullableContext(1)]
		public UParticleModuleVectorFieldLocal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldLocal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600D87F RID: 55423 RVA: 0x0013F6EB File Offset: 0x0013D8EB
		// (set) Token: 0x0600D880 RID: 55424 RVA: 0x0013F6FF File Offset: 0x0013D8FF
		[Nullable(2)]
		public unsafe UVectorField VectorField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorField>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleVectorFieldLocal.__PropertyOffset_VectorField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleVectorFieldLocal.__PropertyOffset_VectorField, value);
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600D881 RID: 55425 RVA: 0x0013F714 File Offset: 0x0013D914
		// (set) Token: 0x0600D882 RID: 55426 RVA: 0x0013F728 File Offset: 0x0013D928
		public unsafe FVector RelativeTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_RelativeTranslation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_RelativeTranslation) = value;
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600D883 RID: 55427 RVA: 0x0013F73D File Offset: 0x0013D93D
		// (set) Token: 0x0600D884 RID: 55428 RVA: 0x0013F751 File Offset: 0x0013D951
		public unsafe FRotator RelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_RelativeRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_RelativeRotation) = value;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600D885 RID: 55429 RVA: 0x0013F766 File Offset: 0x0013D966
		// (set) Token: 0x0600D886 RID: 55430 RVA: 0x0013F77A File Offset: 0x0013D97A
		public unsafe FVector RelativeScale3D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_RelativeScale3D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_RelativeScale3D) = value;
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600D887 RID: 55431 RVA: 0x0013F78F File Offset: 0x0013D98F
		// (set) Token: 0x0600D888 RID: 55432 RVA: 0x0013F79F File Offset: 0x0013D99F
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600D889 RID: 55433 RVA: 0x0013F7B0 File Offset: 0x0013D9B0
		// (set) Token: 0x0600D88A RID: 55434 RVA: 0x0013F7C0 File Offset: 0x0013D9C0
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_Tightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_Tightness) = value;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600D88B RID: 55435 RVA: 0x0013F7D1 File Offset: 0x0013D9D1
		// (set) Token: 0x0600D88C RID: 55436 RVA: 0x0013F7EA File Offset: 0x0013D9EA
		public unsafe bool bIgnoreComponentTransform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bIgnoreComponentTransform) & UParticleModuleVectorFieldLocal.__PropertyMask_bIgnoreComponentTransform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bIgnoreComponentTransform) = ((*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bIgnoreComponentTransform) & ~UParticleModuleVectorFieldLocal.__PropertyMask_bIgnoreComponentTransform) | (value ? UParticleModuleVectorFieldLocal.__PropertyMask_bIgnoreComponentTransform : 0));
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600D88D RID: 55437 RVA: 0x0013F81A File Offset: 0x0013DA1A
		// (set) Token: 0x0600D88E RID: 55438 RVA: 0x0013F833 File Offset: 0x0013DA33
		public unsafe bool bTileX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileX) & UParticleModuleVectorFieldLocal.__PropertyMask_bTileX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileX) = ((*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileX) & ~UParticleModuleVectorFieldLocal.__PropertyMask_bTileX) | (value ? UParticleModuleVectorFieldLocal.__PropertyMask_bTileX : 0));
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600D88F RID: 55439 RVA: 0x0013F863 File Offset: 0x0013DA63
		// (set) Token: 0x0600D890 RID: 55440 RVA: 0x0013F87C File Offset: 0x0013DA7C
		public unsafe bool bTileY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileY) & UParticleModuleVectorFieldLocal.__PropertyMask_bTileY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileY) = ((*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileY) & ~UParticleModuleVectorFieldLocal.__PropertyMask_bTileY) | (value ? UParticleModuleVectorFieldLocal.__PropertyMask_bTileY : 0));
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600D891 RID: 55441 RVA: 0x0013F8AC File Offset: 0x0013DAAC
		// (set) Token: 0x0600D892 RID: 55442 RVA: 0x0013F8C5 File Offset: 0x0013DAC5
		public unsafe bool bTileZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileZ) & UParticleModuleVectorFieldLocal.__PropertyMask_bTileZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileZ) = ((*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bTileZ) & ~UParticleModuleVectorFieldLocal.__PropertyMask_bTileZ) | (value ? UParticleModuleVectorFieldLocal.__PropertyMask_bTileZ : 0));
			}
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600D893 RID: 55443 RVA: 0x0013F8F5 File Offset: 0x0013DAF5
		// (set) Token: 0x0600D894 RID: 55444 RVA: 0x0013F90E File Offset: 0x0013DB0E
		public unsafe bool bUseFixDT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bUseFixDT) & UParticleModuleVectorFieldLocal.__PropertyMask_bUseFixDT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bUseFixDT) = ((*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldLocal.__PropertyOffset_bUseFixDT) & ~UParticleModuleVectorFieldLocal.__PropertyMask_bUseFixDT) | (value ? UParticleModuleVectorFieldLocal.__PropertyMask_bUseFixDT : 0));
			}
		}

		// Token: 0x0600D895 RID: 55445 RVA: 0x0013F93E File Offset: 0x0013DB3E
		static UParticleModuleVectorFieldLocal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldLocal");
		}

		// Token: 0x0600D896 RID: 55446 RVA: 0x0013F94C File Offset: 0x0013DB4C
		protected UParticleModuleVectorFieldLocal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007552 RID: 30034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldLocal";

		// Token: 0x04007553 RID: 30035
		private static IntPtr _ClassPtr;

		// Token: 0x04007554 RID: 30036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007555 RID: 30037
		internal static int __PropertyOffset_VectorField;

		// Token: 0x04007556 RID: 30038
		internal static int __PropertyOffset_RelativeTranslation;

		// Token: 0x04007557 RID: 30039
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x04007558 RID: 30040
		internal static int __PropertyOffset_RelativeScale3D;

		// Token: 0x04007559 RID: 30041
		internal static int __PropertyOffset_Intensity;

		// Token: 0x0400755A RID: 30042
		internal static int __PropertyOffset_Tightness;

		// Token: 0x0400755B RID: 30043
		internal static int __PropertyOffset_bIgnoreComponentTransform;

		// Token: 0x0400755C RID: 30044
		internal static byte __PropertyMask_bIgnoreComponentTransform;

		// Token: 0x0400755D RID: 30045
		internal static int __PropertyOffset_bTileX;

		// Token: 0x0400755E RID: 30046
		internal static byte __PropertyMask_bTileX;

		// Token: 0x0400755F RID: 30047
		internal static int __PropertyOffset_bTileY;

		// Token: 0x04007560 RID: 30048
		internal static byte __PropertyMask_bTileY;

		// Token: 0x04007561 RID: 30049
		internal static int __PropertyOffset_bTileZ;

		// Token: 0x04007562 RID: 30050
		internal static byte __PropertyMask_bTileZ;

		// Token: 0x04007563 RID: 30051
		internal static int __PropertyOffset_bUseFixDT;

		// Token: 0x04007564 RID: 30052
		internal static byte __PropertyMask_bUseFixDT;
	}
}
