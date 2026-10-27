using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E6D RID: 3693
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTransform")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionTransform : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C58C RID: 50572 RVA: 0x0011E0B5 File Offset: 0x0011C2B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTransform._ClassPtr;
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x0011E0C4 File Offset: 0x0011C2C4
		public UMaterialExpressionTransform() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTransform.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C58E RID: 50574 RVA: 0x0011E0EC File Offset: 0x0011C2EC
		[NullableContext(1)]
		public UMaterialExpressionTransform(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTransform.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600C58F RID: 50575 RVA: 0x0011E120 File Offset: 0x0011C320
		// (set) Token: 0x0600C590 RID: 50576 RVA: 0x0011E159 File Offset: 0x0011C359
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
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTransform.__PropertyOffset_Input, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTransform.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600C591 RID: 50577 RVA: 0x0011E17A File Offset: 0x0011C37A
		// (set) Token: 0x0600C592 RID: 50578 RVA: 0x0011E18E File Offset: 0x0011C38E
		public unsafe TEnumAsByte<EMaterialVectorCoordTransformSource> TransformSourceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTransform.__PropertyOffset_TransformSourceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTransform.__PropertyOffset_TransformSourceType) = value;
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600C593 RID: 50579 RVA: 0x0011E1A3 File Offset: 0x0011C3A3
		// (set) Token: 0x0600C594 RID: 50580 RVA: 0x0011E1B7 File Offset: 0x0011C3B7
		public unsafe TEnumAsByte<EMaterialVectorCoordTransform> TransformType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTransform.__PropertyOffset_TransformType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTransform.__PropertyOffset_TransformType) = value;
			}
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x0011E1CC File Offset: 0x0011C3CC
		static UMaterialExpressionTransform()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTransform");
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x0011E1DA File Offset: 0x0011C3DA
		protected UMaterialExpressionTransform(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069AC RID: 27052
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTransform";

		// Token: 0x040069AD RID: 27053
		private static IntPtr _ClassPtr;

		// Token: 0x040069AE RID: 27054
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069AF RID: 27055
		internal static int __PropertyOffset_Input;

		// Token: 0x040069B0 RID: 27056
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x040069B1 RID: 27057
		internal static int __PropertyOffset_TransformSourceType;

		// Token: 0x040069B2 RID: 27058
		internal static int __PropertyOffset_TransformType;
	}
}
