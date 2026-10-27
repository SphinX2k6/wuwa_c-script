using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028AA RID: 10410
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineAnimationStateMixData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSpineAnimationStateMixData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602698E RID: 158094 RVA: 0x003AE6FD File Offset: 0x003AC8FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineAnimationStateMixData._ScriptStructPtr != 0) ? FSpineAnimationStateMixData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SpinePlugin.SpineAnimationStateMixData", ref FSpineAnimationStateMixData._ScriptStructPtr);
		}

		// Token: 0x170094C9 RID: 38089
		// (get) Token: 0x0602698F RID: 158095 RVA: 0x003AE721 File Offset: 0x003AC921
		// (set) Token: 0x06026990 RID: 158096 RVA: 0x003AE735 File Offset: 0x003AC935
		public unsafe string From
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpineAnimationStateMixData.__PropertyOffset_From)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpineAnimationStateMixData.__PropertyOffset_From)), value);
			}
		}

		// Token: 0x170094CA RID: 38090
		// (get) Token: 0x06026991 RID: 158097 RVA: 0x003AE74A File Offset: 0x003AC94A
		// (set) Token: 0x06026992 RID: 158098 RVA: 0x003AE75E File Offset: 0x003AC95E
		public unsafe string To
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpineAnimationStateMixData.__PropertyOffset_To)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpineAnimationStateMixData.__PropertyOffset_To)), value);
			}
		}

		// Token: 0x170094CB RID: 38091
		// (get) Token: 0x06026993 RID: 158099 RVA: 0x003AE773 File Offset: 0x003AC973
		// (set) Token: 0x06026994 RID: 158100 RVA: 0x003AE783 File Offset: 0x003AC983
		public unsafe float Mix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineAnimationStateMixData.__PropertyOffset_Mix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineAnimationStateMixData.__PropertyOffset_Mix) = value;
			}
		}

		// Token: 0x06026995 RID: 158101 RVA: 0x003AE794 File Offset: 0x003AC994
		public FSpineAnimationStateMixData()
		{
		}

		// Token: 0x06026996 RID: 158102 RVA: 0x003AE79C File Offset: 0x003AC99C
		public FSpineAnimationStateMixData(string From, string To, float Mix)
		{
			this.From = From;
			this.To = To;
			this.Mix = Mix;
		}

		// Token: 0x06026997 RID: 158103 RVA: 0x003AE7B9 File Offset: 0x003AC9B9
		protected override IntPtr GetUStructPtr()
		{
			return FSpineAnimationStateMixData.StaticStruct();
		}

		// Token: 0x06026998 RID: 158104 RVA: 0x003AE7C5 File Offset: 0x003AC9C5
		[NullableContext(2)]
		public FSpineAnimationStateMixData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026999 RID: 158105 RVA: 0x003AE7CF File Offset: 0x003AC9CF
		public FSpineAnimationStateMixData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602699A RID: 158106 RVA: 0x003AE7DA File Offset: 0x003AC9DA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineAnimationStateMixData(Pointer, false, true);
		}

		// Token: 0x0602699B RID: 158107 RVA: 0x003AE7E4 File Offset: 0x003AC9E4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineAnimationStateMixData(Pointer, MemoryOwner);
		}

		// Token: 0x04015333 RID: 86835
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationStateMixData";

		// Token: 0x04015334 RID: 86836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015335 RID: 86837
		internal static int __PropertyOffset_From;

		// Token: 0x04015336 RID: 86838
		internal static int __PropertyOffset_To;

		// Token: 0x04015337 RID: 86839
		internal static int __PropertyOffset_Mix;
	}
}
