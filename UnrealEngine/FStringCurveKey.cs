using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011B2 RID: 4530
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StringCurveKey")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FStringCurveKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B49 RID: 68425 RVA: 0x00188772 File Offset: 0x00186972
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStringCurveKey._ScriptStructPtr != 0) ? FStringCurveKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StringCurveKey", ref FStringCurveKey._ScriptStructPtr);
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x06010B4A RID: 68426 RVA: 0x00188796 File Offset: 0x00186996
		// (set) Token: 0x06010B4B RID: 68427 RVA: 0x001887A6 File Offset: 0x001869A6
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStringCurveKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStringCurveKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x06010B4C RID: 68428 RVA: 0x001887B7 File Offset: 0x001869B7
		// (set) Token: 0x06010B4D RID: 68429 RVA: 0x001887CB File Offset: 0x001869CB
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FStringCurveKey.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FStringCurveKey.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x06010B4E RID: 68430 RVA: 0x001887E0 File Offset: 0x001869E0
		public FStringCurveKey()
		{
		}

		// Token: 0x06010B4F RID: 68431 RVA: 0x001887E8 File Offset: 0x001869E8
		public FStringCurveKey(float Time, string Value)
		{
			this.Time = Time;
			this.Value = Value;
		}

		// Token: 0x06010B50 RID: 68432 RVA: 0x001887FE File Offset: 0x001869FE
		protected override IntPtr GetUStructPtr()
		{
			return FStringCurveKey.StaticStruct();
		}

		// Token: 0x06010B51 RID: 68433 RVA: 0x0018880A File Offset: 0x00186A0A
		[NullableContext(2)]
		public FStringCurveKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B52 RID: 68434 RVA: 0x00188814 File Offset: 0x00186A14
		public FStringCurveKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B53 RID: 68435 RVA: 0x0018881F File Offset: 0x00186A1F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStringCurveKey(Pointer, false, true);
		}

		// Token: 0x06010B54 RID: 68436 RVA: 0x00188829 File Offset: 0x00186A29
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStringCurveKey(Pointer, MemoryOwner);
		}

		// Token: 0x04008EED RID: 36589
		public const string __ObjectPath = "/Script/Engine.StringCurveKey";

		// Token: 0x04008EEE RID: 36590
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EEF RID: 36591
		internal static int __PropertyOffset_Time;

		// Token: 0x04008EF0 RID: 36592
		internal static int __PropertyOffset_Value;
	}
}
