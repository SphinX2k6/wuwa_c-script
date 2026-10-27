using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E34 RID: 3636
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSceneColorWithoutWater")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMaterialExpressionSceneColorWithoutWater : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C378 RID: 50040 RVA: 0x0011A406 File Offset: 0x00118606
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSceneColorWithoutWater._ClassPtr;
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x0011A414 File Offset: 0x00118614
		public UMaterialExpressionSceneColorWithoutWater() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneColorWithoutWater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x0011A43C File Offset: 0x0011863C
		[NullableContext(1)]
		public UMaterialExpressionSceneColorWithoutWater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneColorWithoutWater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600C37B RID: 50043 RVA: 0x0011A46F File Offset: 0x0011866F
		// (set) Token: 0x0600C37C RID: 50044 RVA: 0x0011A483 File Offset: 0x00118683
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneColorWithoutWater.__PropertyOffset_InputMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneColorWithoutWater.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0600C37D RID: 50045 RVA: 0x0011A498 File Offset: 0x00118698
		// (set) Token: 0x0600C37E RID: 50046 RVA: 0x0011A4D1 File Offset: 0x001186D1
		[Nullable(1)]
		public FExpressionInput Input
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneColorWithoutWater.__PropertyOffset_Input, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneColorWithoutWater.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0600C37F RID: 50047 RVA: 0x0011A4F2 File Offset: 0x001186F2
		// (set) Token: 0x0600C380 RID: 50048 RVA: 0x0011A506 File Offset: 0x00118706
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneColorWithoutWater.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneColorWithoutWater.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x0011A51B File Offset: 0x0011871B
		static UMaterialExpressionSceneColorWithoutWater()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSceneColorWithoutWater");
		}

		// Token: 0x0600C382 RID: 50050 RVA: 0x0011A529 File Offset: 0x00118729
		protected UMaterialExpressionSceneColorWithoutWater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006839 RID: 26681
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSceneColorWithoutWater";

		// Token: 0x0400683A RID: 26682
		private static IntPtr _ClassPtr;

		// Token: 0x0400683B RID: 26683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400683C RID: 26684
		internal static int __PropertyOffset_InputMode;

		// Token: 0x0400683D RID: 26685
		internal static int __PropertyOffset_Input;

		// Token: 0x0400683E RID: 26686
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400683F RID: 26687
		internal static int __PropertyOffset_ConstInput;
	}
}
