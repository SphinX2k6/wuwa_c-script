using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB4 RID: 3508
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDepthOfFieldFunction")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionDepthOfFieldFunction : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEAC RID: 48812 RVA: 0x0011123F File Offset: 0x0010F43F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDepthOfFieldFunction._ClassPtr;
		}

		// Token: 0x0600BEAD RID: 48813 RVA: 0x0011124C File Offset: 0x0010F44C
		public UMaterialExpressionDepthOfFieldFunction() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDepthOfFieldFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEAE RID: 48814 RVA: 0x00111274 File Offset: 0x0010F474
		[NullableContext(1)]
		public UMaterialExpressionDepthOfFieldFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDepthOfFieldFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x001112A7 File Offset: 0x0010F4A7
		// (set) Token: 0x0600BEB0 RID: 48816 RVA: 0x001112BB File Offset: 0x0010F4BB
		public unsafe TEnumAsByte<EDepthOfFieldFunctionValue> FunctionValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDepthOfFieldFunction.__PropertyOffset_FunctionValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDepthOfFieldFunction.__PropertyOffset_FunctionValue) = value;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x001112D0 File Offset: 0x0010F4D0
		// (set) Token: 0x0600BEB2 RID: 48818 RVA: 0x00111309 File Offset: 0x0010F509
		[Nullable(1)]
		public FExpressionInput Depth
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Depth) == null)
				{
					result = (this._Depth = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDepthOfFieldFunction.__PropertyOffset_Depth, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDepthOfFieldFunction.__PropertyOffset_Depth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BEB3 RID: 48819 RVA: 0x0011132A File Offset: 0x0010F52A
		static UMaterialExpressionDepthOfFieldFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDepthOfFieldFunction");
		}

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x00111338 File Offset: 0x0010F538
		protected UMaterialExpressionDepthOfFieldFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064D2 RID: 25810
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDepthOfFieldFunction";

		// Token: 0x040064D3 RID: 25811
		private static IntPtr _ClassPtr;

		// Token: 0x040064D4 RID: 25812
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064D5 RID: 25813
		internal static int __PropertyOffset_FunctionValue;

		// Token: 0x040064D6 RID: 25814
		internal static int __PropertyOffset_Depth;

		// Token: 0x040064D7 RID: 25815
		[Nullable(2)]
		private FExpressionInput _Depth;
	}
}
