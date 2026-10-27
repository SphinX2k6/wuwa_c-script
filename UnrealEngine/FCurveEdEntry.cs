using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000979 RID: 2425
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveEdEntry")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FCurveEdEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600892F RID: 35119 RVA: 0x000C4725 File Offset: 0x000C2925
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCurveEdEntry._ScriptStructPtr != 0) ? FCurveEdEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CurveEdEntry", ref FCurveEdEntry._ScriptStructPtr);
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06008930 RID: 35120 RVA: 0x000C4749 File Offset: 0x000C2949
		// (set) Token: 0x06008931 RID: 35121 RVA: 0x000C475D File Offset: 0x000C295D
		[Nullable(2)]
		public unsafe UObject CurveObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FCurveEdEntry.__PropertyOffset_CurveObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCurveEdEntry.__PropertyOffset_CurveObject, value);
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06008932 RID: 35122 RVA: 0x000C4772 File Offset: 0x000C2972
		// (set) Token: 0x06008933 RID: 35123 RVA: 0x000C4786 File Offset: 0x000C2986
		public unsafe FColor CurveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_CurveColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_CurveColor) = value;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06008934 RID: 35124 RVA: 0x000C479B File Offset: 0x000C299B
		// (set) Token: 0x06008935 RID: 35125 RVA: 0x000C47AF File Offset: 0x000C29AF
		public unsafe string CurveName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCurveEdEntry.__PropertyOffset_CurveName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCurveEdEntry.__PropertyOffset_CurveName)), value);
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06008936 RID: 35126 RVA: 0x000C47C4 File Offset: 0x000C29C4
		// (set) Token: 0x06008937 RID: 35127 RVA: 0x000C47D4 File Offset: 0x000C29D4
		public unsafe int bHideCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bHideCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bHideCurve) = value;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06008938 RID: 35128 RVA: 0x000C47E5 File Offset: 0x000C29E5
		// (set) Token: 0x06008939 RID: 35129 RVA: 0x000C47F5 File Offset: 0x000C29F5
		public unsafe int bColorCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bColorCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bColorCurve) = value;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600893A RID: 35130 RVA: 0x000C4806 File Offset: 0x000C2A06
		// (set) Token: 0x0600893B RID: 35131 RVA: 0x000C4816 File Offset: 0x000C2A16
		public unsafe int bFloatingPointColorCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bFloatingPointColorCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bFloatingPointColorCurve) = value;
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600893C RID: 35132 RVA: 0x000C4827 File Offset: 0x000C2A27
		// (set) Token: 0x0600893D RID: 35133 RVA: 0x000C4837 File Offset: 0x000C2A37
		public unsafe int bClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_bClamp) = value;
			}
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600893E RID: 35134 RVA: 0x000C4848 File Offset: 0x000C2A48
		// (set) Token: 0x0600893F RID: 35135 RVA: 0x000C4858 File Offset: 0x000C2A58
		public unsafe float ClampLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_ClampLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_ClampLow) = value;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06008940 RID: 35136 RVA: 0x000C4869 File Offset: 0x000C2A69
		// (set) Token: 0x06008941 RID: 35137 RVA: 0x000C4879 File Offset: 0x000C2A79
		public unsafe float ClampHigh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_ClampHigh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdEntry.__PropertyOffset_ClampHigh) = value;
			}
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x000C488A File Offset: 0x000C2A8A
		public FCurveEdEntry()
		{
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x000C4894 File Offset: 0x000C2A94
		public FCurveEdEntry(UObject CurveObject, FColor CurveColor, string CurveName, int bHideCurve, int bColorCurve, int bFloatingPointColorCurve, int bClamp, float ClampLow, float ClampHigh)
		{
			this.CurveObject = CurveObject;
			this.CurveColor = CurveColor;
			this.CurveName = CurveName;
			this.bHideCurve = bHideCurve;
			this.bColorCurve = bColorCurve;
			this.bFloatingPointColorCurve = bFloatingPointColorCurve;
			this.bClamp = bClamp;
			this.ClampLow = ClampLow;
			this.ClampHigh = ClampHigh;
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x000C48EC File Offset: 0x000C2AEC
		protected override IntPtr GetUStructPtr()
		{
			return FCurveEdEntry.StaticStruct();
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x000C48F8 File Offset: 0x000C2AF8
		[NullableContext(2)]
		public FCurveEdEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x000C4902 File Offset: 0x000C2B02
		public FCurveEdEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x000C490D File Offset: 0x000C2B0D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCurveEdEntry(Pointer, false, true);
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x000C4917 File Offset: 0x000C2B17
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCurveEdEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04004129 RID: 16681
		public const string __ObjectPath = "/Script/Engine.CurveEdEntry";

		// Token: 0x0400412A RID: 16682
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400412B RID: 16683
		internal static int __PropertyOffset_CurveObject;

		// Token: 0x0400412C RID: 16684
		internal static int __PropertyOffset_CurveColor;

		// Token: 0x0400412D RID: 16685
		internal static int __PropertyOffset_CurveName;

		// Token: 0x0400412E RID: 16686
		internal static int __PropertyOffset_bHideCurve;

		// Token: 0x0400412F RID: 16687
		internal static int __PropertyOffset_bColorCurve;

		// Token: 0x04004130 RID: 16688
		internal static int __PropertyOffset_bFloatingPointColorCurve;

		// Token: 0x04004131 RID: 16689
		internal static int __PropertyOffset_bClamp;

		// Token: 0x04004132 RID: 16690
		internal static int __PropertyOffset_ClampLow;

		// Token: 0x04004133 RID: 16691
		internal static int __PropertyOffset_ClampHigh;
	}
}
