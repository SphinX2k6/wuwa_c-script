using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC8 RID: 3528
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFmod")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionFmod : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF52 RID: 48978 RVA: 0x0011263D File Offset: 0x0011083D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFmod._ClassPtr;
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x0011264C File Offset: 0x0011084C
		public UMaterialExpressionFmod() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFmod.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x00112674 File Offset: 0x00110874
		public UMaterialExpressionFmod(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFmod.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x0600BF55 RID: 48981 RVA: 0x001126A8 File Offset: 0x001108A8
		// (set) Token: 0x0600BF56 RID: 48982 RVA: 0x001126E1 File Offset: 0x001108E1
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFmod.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFmod.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x00112704 File Offset: 0x00110904
		// (set) Token: 0x0600BF58 RID: 48984 RVA: 0x0011273D File Offset: 0x0011093D
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFmod.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFmod.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF59 RID: 48985 RVA: 0x0011275E File Offset: 0x0011095E
		static UMaterialExpressionFmod()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFmod");
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x0011276C File Offset: 0x0011096C
		protected UMaterialExpressionFmod(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006548 RID: 25928
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFmod";

		// Token: 0x04006549 RID: 25929
		private static IntPtr _ClassPtr;

		// Token: 0x0400654A RID: 25930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400654B RID: 25931
		internal static int __PropertyOffset_A;

		// Token: 0x0400654C RID: 25932
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x0400654D RID: 25933
		internal static int __PropertyOffset_B;

		// Token: 0x0400654E RID: 25934
		[Nullable(2)]
		private FExpressionInput _B;
	}
}
