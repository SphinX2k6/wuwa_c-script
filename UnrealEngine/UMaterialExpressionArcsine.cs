using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D86 RID: 3462
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArcsine")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionArcsine : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD1A RID: 48410 RVA: 0x0010E561 File Offset: 0x0010C761
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArcsine._ClassPtr;
		}

		// Token: 0x0600BD1B RID: 48411 RVA: 0x0010E570 File Offset: 0x0010C770
		public UMaterialExpressionArcsine() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArcsine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x0010E598 File Offset: 0x0010C798
		public UMaterialExpressionArcsine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArcsine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x0010E5CC File Offset: 0x0010C7CC
		// (set) Token: 0x0600BD1E RID: 48414 RVA: 0x0010E605 File Offset: 0x0010C805
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArcsine.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArcsine.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x0010E626 File Offset: 0x0010C826
		static UMaterialExpressionArcsine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArcsine");
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x0010E634 File Offset: 0x0010C834
		protected UMaterialExpressionArcsine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063BF RID: 25535
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArcsine";

		// Token: 0x040063C0 RID: 25536
		private static IntPtr _ClassPtr;

		// Token: 0x040063C1 RID: 25537
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063C2 RID: 25538
		internal static int __PropertyOffset_Input;

		// Token: 0x040063C3 RID: 25539
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
