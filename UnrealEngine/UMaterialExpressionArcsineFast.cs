using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D87 RID: 3463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArcsineFast")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionArcsineFast : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD21 RID: 48417 RVA: 0x0010E63D File Offset: 0x0010C83D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArcsineFast._ClassPtr;
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x0010E64C File Offset: 0x0010C84C
		public UMaterialExpressionArcsineFast() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArcsineFast.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x0010E674 File Offset: 0x0010C874
		public UMaterialExpressionArcsineFast(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArcsineFast.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x0010E6A8 File Offset: 0x0010C8A8
		// (set) Token: 0x0600BD25 RID: 48421 RVA: 0x0010E6E1 File Offset: 0x0010C8E1
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArcsineFast.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArcsineFast.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD26 RID: 48422 RVA: 0x0010E702 File Offset: 0x0010C902
		static UMaterialExpressionArcsineFast()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArcsineFast");
		}

		// Token: 0x0600BD27 RID: 48423 RVA: 0x0010E710 File Offset: 0x0010C910
		protected UMaterialExpressionArcsineFast(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063C4 RID: 25540
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArcsineFast";

		// Token: 0x040063C5 RID: 25541
		private static IntPtr _ClassPtr;

		// Token: 0x040063C6 RID: 25542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063C7 RID: 25543
		internal static int __PropertyOffset_Input;

		// Token: 0x040063C8 RID: 25544
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
