using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002205 RID: 8709
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkFrameRate")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLiveLinkFrameRate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212E1 RID: 135905 RVA: 0x0030EBC1 File Offset: 0x0030CDC1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkFrameRate._ScriptStructPtr != 0) ? FLiveLinkFrameRate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkFrameRate", ref FLiveLinkFrameRate._ScriptStructPtr);
		}

		// Token: 0x17008184 RID: 33156
		// (get) Token: 0x060212E2 RID: 135906 RVA: 0x0030EBE5 File Offset: 0x0030CDE5
		// (set) Token: 0x060212E3 RID: 135907 RVA: 0x0030EBF5 File Offset: 0x0030CDF5
		public unsafe int Numerator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkFrameRate.__PropertyOffset_Numerator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkFrameRate.__PropertyOffset_Numerator) = value;
			}
		}

		// Token: 0x17008185 RID: 33157
		// (get) Token: 0x060212E4 RID: 135908 RVA: 0x0030EC06 File Offset: 0x0030CE06
		// (set) Token: 0x060212E5 RID: 135909 RVA: 0x0030EC16 File Offset: 0x0030CE16
		public unsafe int Denominator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkFrameRate.__PropertyOffset_Denominator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkFrameRate.__PropertyOffset_Denominator) = value;
			}
		}

		// Token: 0x060212E6 RID: 135910 RVA: 0x0030EC27 File Offset: 0x0030CE27
		public FLiveLinkFrameRate()
		{
		}

		// Token: 0x060212E7 RID: 135911 RVA: 0x0030EC2F File Offset: 0x0030CE2F
		public FLiveLinkFrameRate(int Numerator, int Denominator)
		{
			this.Numerator = Numerator;
			this.Denominator = Denominator;
		}

		// Token: 0x060212E8 RID: 135912 RVA: 0x0030EC45 File Offset: 0x0030CE45
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkFrameRate.StaticStruct();
		}

		// Token: 0x060212E9 RID: 135913 RVA: 0x0030EC51 File Offset: 0x0030CE51
		[NullableContext(2)]
		public FLiveLinkFrameRate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212EA RID: 135914 RVA: 0x0030EC5B File Offset: 0x0030CE5B
		public FLiveLinkFrameRate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212EB RID: 135915 RVA: 0x0030EC66 File Offset: 0x0030CE66
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkFrameRate(Pointer, false, true);
		}

		// Token: 0x060212EC RID: 135916 RVA: 0x0030EC70 File Offset: 0x0030CE70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkFrameRate(Pointer, MemoryOwner);
		}

		// Token: 0x04011B3E RID: 72510
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkFrameRate";

		// Token: 0x04011B3F RID: 72511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B40 RID: 72512
		internal static int __PropertyOffset_Numerator;

		// Token: 0x04011B41 RID: 72513
		internal static int __PropertyOffset_Denominator;
	}
}
