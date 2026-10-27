using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021FE RID: 8702
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCurveElement")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkCurveElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602129E RID: 135838 RVA: 0x0030E620 File Offset: 0x0030C820
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkCurveElement._ScriptStructPtr != 0) ? FLiveLinkCurveElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkCurveElement", ref FLiveLinkCurveElement._ScriptStructPtr);
		}

		// Token: 0x17008179 RID: 33145
		// (get) Token: 0x0602129F RID: 135839 RVA: 0x0030E644 File Offset: 0x0030C844
		// (set) Token: 0x060212A0 RID: 135840 RVA: 0x0030E658 File Offset: 0x0030C858
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCurveElement.__PropertyOffset_CurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCurveElement.__PropertyOffset_CurveName) = value;
			}
		}

		// Token: 0x1700817A RID: 33146
		// (get) Token: 0x060212A1 RID: 135841 RVA: 0x0030E66D File Offset: 0x0030C86D
		// (set) Token: 0x060212A2 RID: 135842 RVA: 0x0030E67D File Offset: 0x0030C87D
		public unsafe float CurveValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkCurveElement.__PropertyOffset_CurveValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkCurveElement.__PropertyOffset_CurveValue) = value;
			}
		}

		// Token: 0x060212A3 RID: 135843 RVA: 0x0030E68E File Offset: 0x0030C88E
		public FLiveLinkCurveElement()
		{
		}

		// Token: 0x060212A4 RID: 135844 RVA: 0x0030E696 File Offset: 0x0030C896
		public FLiveLinkCurveElement(FName CurveName, float CurveValue)
		{
			this.CurveName = CurveName;
			this.CurveValue = CurveValue;
		}

		// Token: 0x060212A5 RID: 135845 RVA: 0x0030E6AC File Offset: 0x0030C8AC
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkCurveElement.StaticStruct();
		}

		// Token: 0x060212A6 RID: 135846 RVA: 0x0030E6B8 File Offset: 0x0030C8B8
		[NullableContext(2)]
		public FLiveLinkCurveElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212A7 RID: 135847 RVA: 0x0030E6C2 File Offset: 0x0030C8C2
		public FLiveLinkCurveElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212A8 RID: 135848 RVA: 0x0030E6CD File Offset: 0x0030C8CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkCurveElement(Pointer, false, true);
		}

		// Token: 0x060212A9 RID: 135849 RVA: 0x0030E6D7 File Offset: 0x0030C8D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkCurveElement(Pointer, MemoryOwner);
		}

		// Token: 0x04011B1D RID: 72477
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCurveElement";

		// Token: 0x04011B1E RID: 72478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B1F RID: 72479
		internal static int __PropertyOffset_CurveName;

		// Token: 0x04011B20 RID: 72480
		internal static int __PropertyOffset_CurveValue;
	}
}
