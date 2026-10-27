using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C94 RID: 3220
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackFloatMaterialParam")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UInterpTrackFloatMaterialParam : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A360 RID: 41824 RVA: 0x000E8309 File Offset: 0x000E6509
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackFloatMaterialParam._ClassPtr;
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x000E8318 File Offset: 0x000E6518
		public UInterpTrackFloatMaterialParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatMaterialParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x000E8340 File Offset: 0x000E6540
		public UInterpTrackFloatMaterialParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatMaterialParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x0600A363 RID: 41827 RVA: 0x000E8374 File Offset: 0x000E6574
		// (set) Token: 0x0600A364 RID: 41828 RVA: 0x000E83AD File Offset: 0x000E65AD
		public TArray<UMaterialInterface> TargetMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._TargetMaterials) == null)
				{
					result = (this._TargetMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UInterpTrackFloatMaterialParam.__PropertyOffset_TargetMaterials, this));
				}
				return result;
			}
			set
			{
				this.TargetMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x0600A365 RID: 41829 RVA: 0x000E83BB File Offset: 0x000E65BB
		// (set) Token: 0x0600A366 RID: 41830 RVA: 0x000E83CF File Offset: 0x000E65CF
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatMaterialParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatMaterialParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x000E83E4 File Offset: 0x000E65E4
		static UInterpTrackFloatMaterialParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackFloatMaterialParam");
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x000E83F2 File Offset: 0x000E65F2
		protected UInterpTrackFloatMaterialParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059C6 RID: 22982
		public new const string __ObjectPath = "/Script/Engine.InterpTrackFloatMaterialParam";

		// Token: 0x040059C7 RID: 22983
		private static IntPtr _ClassPtr;

		// Token: 0x040059C8 RID: 22984
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059C9 RID: 22985
		internal static int __PropertyOffset_TargetMaterials;

		// Token: 0x040059CA RID: 22986
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _TargetMaterials;

		// Token: 0x040059CB RID: 22987
		internal static int __PropertyOffset_ParamName;
	}
}
