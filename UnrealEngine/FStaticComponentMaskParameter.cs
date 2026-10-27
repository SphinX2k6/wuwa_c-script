using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200118B RID: 4491
	[UnrealObjectPath("/Script/Engine.StaticComponentMaskParameter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FStaticComponentMaskParameter : FStaticParameterBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010803 RID: 67587 RVA: 0x00183A9B File Offset: 0x00181C9B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticComponentMaskParameter._ScriptStructPtr != 0) ? FStaticComponentMaskParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticComponentMaskParameter", ref FStaticComponentMaskParameter._ScriptStructPtr);
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x06010804 RID: 67588 RVA: 0x00183ABF File Offset: 0x00181CBF
		// (set) Token: 0x06010805 RID: 67589 RVA: 0x00183ACF File Offset: 0x00181CCF
		public unsafe bool R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_R) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_R) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x06010806 RID: 67590 RVA: 0x00183AE0 File Offset: 0x00181CE0
		// (set) Token: 0x06010807 RID: 67591 RVA: 0x00183AF0 File Offset: 0x00181CF0
		public unsafe bool G
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_G) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_G) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x06010808 RID: 67592 RVA: 0x00183B01 File Offset: 0x00181D01
		// (set) Token: 0x06010809 RID: 67593 RVA: 0x00183B11 File Offset: 0x00181D11
		public unsafe bool B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_B) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_B) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x0601080A RID: 67594 RVA: 0x00183B22 File Offset: 0x00181D22
		// (set) Token: 0x0601080B RID: 67595 RVA: 0x00183B32 File Offset: 0x00181D32
		public unsafe bool A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_A) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticComponentMaskParameter.__PropertyOffset_A) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601080C RID: 67596 RVA: 0x00183B43 File Offset: 0x00181D43
		public FStaticComponentMaskParameter()
		{
		}

		// Token: 0x0601080D RID: 67597 RVA: 0x00183B4B File Offset: 0x00181D4B
		[NullableContext(1)]
		public FStaticComponentMaskParameter(bool R, bool G, bool B, bool A, FMaterialParameterInfo ParameterInfo, bool bOverride, FGuid ExpressionGUID)
		{
			this.R = R;
			this.G = G;
			this.B = B;
			this.A = A;
			base.ParameterInfo = ParameterInfo;
			base.bOverride = bOverride;
			base.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0601080E RID: 67598 RVA: 0x00183B88 File Offset: 0x00181D88
		protected override IntPtr GetUStructPtr()
		{
			return FStaticComponentMaskParameter.StaticStruct();
		}

		// Token: 0x0601080F RID: 67599 RVA: 0x00183B94 File Offset: 0x00181D94
		[NullableContext(2)]
		public FStaticComponentMaskParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010810 RID: 67600 RVA: 0x00183B9E File Offset: 0x00181D9E
		public FStaticComponentMaskParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010811 RID: 67601 RVA: 0x00183BA9 File Offset: 0x00181DA9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticComponentMaskParameter(Pointer, false, true);
		}

		// Token: 0x06010812 RID: 67602 RVA: 0x00183BB3 File Offset: 0x00181DB3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticComponentMaskParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04008D34 RID: 36148
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticComponentMaskParameter";

		// Token: 0x04008D35 RID: 36149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008D36 RID: 36150
		internal static int __PropertyOffset_R;

		// Token: 0x04008D37 RID: 36151
		internal static int __PropertyOffset_G;

		// Token: 0x04008D38 RID: 36152
		internal static int __PropertyOffset_B;

		// Token: 0x04008D39 RID: 36153
		internal static int __PropertyOffset_A;
	}
}
