using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011F4 RID: 4596
	[UnrealObjectPath("/Script/Engine.TimeStretchCurveInstance")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTimeStretchCurveInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F1B RID: 69403 RVA: 0x0018DFDF File Offset: 0x0018C1DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimeStretchCurveInstance._ScriptStructPtr != 0) ? FTimeStretchCurveInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimeStretchCurveInstance", ref FTimeStretchCurveInstance._ScriptStructPtr);
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x06010F1C RID: 69404 RVA: 0x0018E003 File Offset: 0x0018C203
		// (set) Token: 0x06010F1D RID: 69405 RVA: 0x0018E013 File Offset: 0x0018C213
		public unsafe bool bHasValidData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeStretchCurveInstance.__PropertyOffset_bHasValidData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeStretchCurveInstance.__PropertyOffset_bHasValidData) = (value ? 1 : 0);
			}
		}

		// Token: 0x06010F1E RID: 69406 RVA: 0x0018E024 File Offset: 0x0018C224
		public FTimeStretchCurveInstance()
		{
		}

		// Token: 0x06010F1F RID: 69407 RVA: 0x0018E02C File Offset: 0x0018C22C
		public FTimeStretchCurveInstance(bool bHasValidData)
		{
			this.bHasValidData = bHasValidData;
		}

		// Token: 0x06010F20 RID: 69408 RVA: 0x0018E03B File Offset: 0x0018C23B
		protected override IntPtr GetUStructPtr()
		{
			return FTimeStretchCurveInstance.StaticStruct();
		}

		// Token: 0x06010F21 RID: 69409 RVA: 0x0018E047 File Offset: 0x0018C247
		[NullableContext(2)]
		public FTimeStretchCurveInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F22 RID: 69410 RVA: 0x0018E051 File Offset: 0x0018C251
		public FTimeStretchCurveInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010F23 RID: 69411 RVA: 0x0018E05C File Offset: 0x0018C25C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimeStretchCurveInstance(Pointer, false, true);
		}

		// Token: 0x06010F24 RID: 69412 RVA: 0x0018E066 File Offset: 0x0018C266
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimeStretchCurveInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04009137 RID: 37175
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TimeStretchCurveInstance";

		// Token: 0x04009138 RID: 37176
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009139 RID: 37177
		internal static int __PropertyOffset_bHasValidData;
	}
}
