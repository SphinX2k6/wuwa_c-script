using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D83 RID: 3459
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAppendVector")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionAppendVector : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD03 RID: 48387 RVA: 0x0010E274 File Offset: 0x0010C474
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAppendVector._ClassPtr;
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x0010E280 File Offset: 0x0010C480
		public UMaterialExpressionAppendVector() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAppendVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x0010E2A8 File Offset: 0x0010C4A8
		public UMaterialExpressionAppendVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAppendVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600BD06 RID: 48390 RVA: 0x0010E2DC File Offset: 0x0010C4DC
		// (set) Token: 0x0600BD07 RID: 48391 RVA: 0x0010E315 File Offset: 0x0010C515
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionAppendVector.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionAppendVector.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0600BD08 RID: 48392 RVA: 0x0010E338 File Offset: 0x0010C538
		// (set) Token: 0x0600BD09 RID: 48393 RVA: 0x0010E371 File Offset: 0x0010C571
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionAppendVector.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionAppendVector.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x0010E392 File Offset: 0x0010C592
		static UMaterialExpressionAppendVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAppendVector");
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x0010E3A0 File Offset: 0x0010C5A0
		protected UMaterialExpressionAppendVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063AE RID: 25518
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAppendVector";

		// Token: 0x040063AF RID: 25519
		private static IntPtr _ClassPtr;

		// Token: 0x040063B0 RID: 25520
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063B1 RID: 25521
		internal static int __PropertyOffset_A;

		// Token: 0x040063B2 RID: 25522
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040063B3 RID: 25523
		internal static int __PropertyOffset_B;

		// Token: 0x040063B4 RID: 25524
		[Nullable(2)]
		private FExpressionInput _B;
	}
}
