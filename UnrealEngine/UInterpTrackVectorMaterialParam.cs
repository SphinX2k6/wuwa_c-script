using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB7 RID: 3255
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackVectorMaterialParam")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UInterpTrackVectorMaterialParam : UInterpTrackVectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A497 RID: 42135 RVA: 0x000EA31D File Offset: 0x000E851D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackVectorMaterialParam._ClassPtr;
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x000EA32C File Offset: 0x000E852C
		public UInterpTrackVectorMaterialParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVectorMaterialParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x000EA354 File Offset: 0x000E8554
		public UInterpTrackVectorMaterialParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVectorMaterialParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x0600A49A RID: 42138 RVA: 0x000EA388 File Offset: 0x000E8588
		// (set) Token: 0x0600A49B RID: 42139 RVA: 0x000EA3C1 File Offset: 0x000E85C1
		public TArray<UMaterialInterface> TargetMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._TargetMaterials) == null)
				{
					result = (this._TargetMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UInterpTrackVectorMaterialParam.__PropertyOffset_TargetMaterials, this));
				}
				return result;
			}
			set
			{
				this.TargetMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x0600A49C RID: 42140 RVA: 0x000EA3CF File Offset: 0x000E85CF
		// (set) Token: 0x0600A49D RID: 42141 RVA: 0x000EA3E3 File Offset: 0x000E85E3
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackVectorMaterialParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackVectorMaterialParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x000EA3F8 File Offset: 0x000E85F8
		static UInterpTrackVectorMaterialParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackVectorMaterialParam");
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x000EA406 File Offset: 0x000E8606
		protected UInterpTrackVectorMaterialParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A95 RID: 23189
		public new const string __ObjectPath = "/Script/Engine.InterpTrackVectorMaterialParam";

		// Token: 0x04005A96 RID: 23190
		private static IntPtr _ClassPtr;

		// Token: 0x04005A97 RID: 23191
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A98 RID: 23192
		internal static int __PropertyOffset_TargetMaterials;

		// Token: 0x04005A99 RID: 23193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _TargetMaterials;

		// Token: 0x04005A9A RID: 23194
		internal static int __PropertyOffset_ParamName;
	}
}
