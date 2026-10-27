using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003C4 RID: 964
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSessionStatus")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FARSessionStatus : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003602 RID: 13826 RVA: 0x00052179 File Offset: 0x00050379
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARSessionStatus._ScriptStructPtr != 0) ? FARSessionStatus._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARSessionStatus", ref FARSessionStatus._ScriptStructPtr);
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x0005219D File Offset: 0x0005039D
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x000521B1 File Offset: 0x000503B1
		public unsafe string AdditionalInfo
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FARSessionStatus.__PropertyOffset_AdditionalInfo)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FARSessionStatus.__PropertyOffset_AdditionalInfo)), value);
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x000521C6 File Offset: 0x000503C6
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x000521D6 File Offset: 0x000503D6
		public unsafe EARSessionStatus Status
		{
			get
			{
				return (EARSessionStatus)(*(base.NativePtr + (IntPtr)FARSessionStatus.__PropertyOffset_Status));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARSessionStatus.__PropertyOffset_Status) = (byte)value;
			}
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x000521E7 File Offset: 0x000503E7
		public FARSessionStatus()
		{
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x000521EF File Offset: 0x000503EF
		public FARSessionStatus(string AdditionalInfo, EARSessionStatus Status)
		{
			this.AdditionalInfo = AdditionalInfo;
			this.Status = Status;
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00052205 File Offset: 0x00050405
		protected override IntPtr GetUStructPtr()
		{
			return FARSessionStatus.StaticStruct();
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00052211 File Offset: 0x00050411
		[NullableContext(2)]
		public FARSessionStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x0005221B File Offset: 0x0005041B
		public FARSessionStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00052226 File Offset: 0x00050426
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARSessionStatus(Pointer, false, true);
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00052230 File Offset: 0x00050430
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARSessionStatus(Pointer, MemoryOwner);
		}

		// Token: 0x0400175C RID: 5980
		public const string __ObjectPath = "/Script/AugmentedReality.ARSessionStatus";

		// Token: 0x0400175D RID: 5981
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400175E RID: 5982
		internal static int __PropertyOffset_AdditionalInfo;

		// Token: 0x0400175F RID: 5983
		internal static int __PropertyOffset_Status;
	}
}
