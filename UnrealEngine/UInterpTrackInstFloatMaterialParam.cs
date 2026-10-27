using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA1 RID: 3233
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackInstFloatMaterialParam")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UInterpTrackInstFloatMaterialParam : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3B7 RID: 41911 RVA: 0x000E8B44 File Offset: 0x000E6D44
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstFloatMaterialParam._ClassPtr;
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x000E8B50 File Offset: 0x000E6D50
		public UInterpTrackInstFloatMaterialParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatMaterialParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x000E8B78 File Offset: 0x000E6D78
		public UInterpTrackInstFloatMaterialParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatMaterialParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x0600A3BA RID: 41914 RVA: 0x000E8BAC File Offset: 0x000E6DAC
		// (set) Token: 0x0600A3BB RID: 41915 RVA: 0x000E8BE5 File Offset: 0x000E6DE5
		public TArray<UMaterialInstanceDynamic> MaterialInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialInstances) == null)
				{
					result = (this._MaterialInstances = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UInterpTrackInstFloatMaterialParam.__PropertyOffset_MaterialInstances, this));
				}
				return result;
			}
			set
			{
				this.MaterialInstances.CopyAssign(value);
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x000E8BF4 File Offset: 0x000E6DF4
		// (set) Token: 0x0600A3BD RID: 41917 RVA: 0x000E8C2D File Offset: 0x000E6E2D
		public TArray<float> ResetFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ResetFloats) == null)
				{
					result = (this._ResetFloats = new TArray<float>(base.NativePtr + (IntPtr)UInterpTrackInstFloatMaterialParam.__PropertyOffset_ResetFloats, this));
				}
				return result;
			}
			set
			{
				this.ResetFloats.CopyAssign(value);
			}
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x0600A3BE RID: 41918 RVA: 0x000E8C3C File Offset: 0x000E6E3C
		// (set) Token: 0x0600A3BF RID: 41919 RVA: 0x000E8C75 File Offset: 0x000E6E75
		public TArray<FPrimitiveMaterialRef> PrimitiveMaterialRefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPrimitiveMaterialRef> result;
				if ((result = this._PrimitiveMaterialRefs) == null)
				{
					result = (this._PrimitiveMaterialRefs = new TArray<FPrimitiveMaterialRef>(base.NativePtr + (IntPtr)UInterpTrackInstFloatMaterialParam.__PropertyOffset_PrimitiveMaterialRefs, this));
				}
				return result;
			}
			set
			{
				this.PrimitiveMaterialRefs.CopyAssign(value);
			}
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x0600A3C0 RID: 41920 RVA: 0x000E8C83 File Offset: 0x000E6E83
		// (set) Token: 0x0600A3C1 RID: 41921 RVA: 0x000E8C97 File Offset: 0x000E6E97
		[Nullable(2)]
		public unsafe UInterpTrackFloatMaterialParam InstancedTrack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpTrackFloatMaterialParam>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstFloatMaterialParam.__PropertyOffset_InstancedTrack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstFloatMaterialParam.__PropertyOffset_InstancedTrack, value);
			}
		}

		// Token: 0x0600A3C2 RID: 41922 RVA: 0x000E8CAC File Offset: 0x000E6EAC
		static UInterpTrackInstFloatMaterialParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstFloatMaterialParam");
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x000E8CBA File Offset: 0x000E6EBA
		protected UInterpTrackInstFloatMaterialParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059F9 RID: 23033
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstFloatMaterialParam";

		// Token: 0x040059FA RID: 23034
		private static IntPtr _ClassPtr;

		// Token: 0x040059FB RID: 23035
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059FC RID: 23036
		internal static int __PropertyOffset_MaterialInstances;

		// Token: 0x040059FD RID: 23037
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialInstances;

		// Token: 0x040059FE RID: 23038
		internal static int __PropertyOffset_ResetFloats;

		// Token: 0x040059FF RID: 23039
		[Nullable(2)]
		private TArray<float> _ResetFloats;

		// Token: 0x04005A00 RID: 23040
		internal static int __PropertyOffset_PrimitiveMaterialRefs;

		// Token: 0x04005A01 RID: 23041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPrimitiveMaterialRef> _PrimitiveMaterialRefs;

		// Token: 0x04005A02 RID: 23042
		internal static int __PropertyOffset_InstancedTrack;
	}
}
