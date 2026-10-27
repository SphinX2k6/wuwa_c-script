using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200108C RID: 4236
	[UnrealObjectPath("/Script/Engine.ResponseChannel")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FResponseChannel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F21E RID: 61982 RVA: 0x00167460 File Offset: 0x00165660
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FResponseChannel._ScriptStructPtr != 0) ? FResponseChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ResponseChannel", ref FResponseChannel._ScriptStructPtr);
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600F21F RID: 61983 RVA: 0x00167484 File Offset: 0x00165684
		// (set) Token: 0x0600F220 RID: 61984 RVA: 0x00167498 File Offset: 0x00165698
		public unsafe FName Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FResponseChannel.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FResponseChannel.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600F221 RID: 61985 RVA: 0x001674AD File Offset: 0x001656AD
		// (set) Token: 0x0600F222 RID: 61986 RVA: 0x001674C1 File Offset: 0x001656C1
		public unsafe TEnumAsByte<ECollisionResponse> Response
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FResponseChannel.__PropertyOffset_Response);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FResponseChannel.__PropertyOffset_Response) = value;
			}
		}

		// Token: 0x0600F223 RID: 61987 RVA: 0x001674D6 File Offset: 0x001656D6
		public FResponseChannel()
		{
		}

		// Token: 0x0600F224 RID: 61988 RVA: 0x001674DE File Offset: 0x001656DE
		public FResponseChannel(FName Channel, TEnumAsByte<ECollisionResponse> Response)
		{
			this.Channel = Channel;
			this.Response = Response;
		}

		// Token: 0x0600F225 RID: 61989 RVA: 0x001674F4 File Offset: 0x001656F4
		protected override IntPtr GetUStructPtr()
		{
			return FResponseChannel.StaticStruct();
		}

		// Token: 0x0600F226 RID: 61990 RVA: 0x00167500 File Offset: 0x00165700
		[NullableContext(2)]
		public FResponseChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F227 RID: 61991 RVA: 0x0016750A File Offset: 0x0016570A
		public FResponseChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F228 RID: 61992 RVA: 0x00167515 File Offset: 0x00165715
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FResponseChannel(Pointer, false, true);
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x0016751F File Offset: 0x0016571F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FResponseChannel(Pointer, MemoryOwner);
		}

		// Token: 0x04008346 RID: 33606
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ResponseChannel";

		// Token: 0x04008347 RID: 33607
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008348 RID: 33608
		internal static int __PropertyOffset_Channel;

		// Token: 0x04008349 RID: 33609
		internal static int __PropertyOffset_Response;
	}
}
