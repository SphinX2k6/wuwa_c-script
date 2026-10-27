using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FC6 RID: 8134
	[UnrealObjectPath("/Script/LGUI.ActorBindingInfo")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FActorBindingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDC7 RID: 126407 RVA: 0x002DDDF9 File Offset: 0x002DBFF9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorBindingInfo._ScriptStructPtr != 0) ? FActorBindingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ActorBindingInfo", ref FActorBindingInfo._ScriptStructPtr);
		}

		// Token: 0x17007AD3 RID: 31443
		// (get) Token: 0x0601EDC8 RID: 126408 RVA: 0x002DDE1D File Offset: 0x002DC01D
		// (set) Token: 0x0601EDC9 RID: 126409 RVA: 0x002DDE31 File Offset: 0x002DC031
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Actor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FActorBindingInfo.__PropertyOffset_Actor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FActorBindingInfo.__PropertyOffset_Actor) = value;
			}
		}

		// Token: 0x17007AD4 RID: 31444
		// (get) Token: 0x0601EDCA RID: 126410 RVA: 0x002DDE46 File Offset: 0x002DC046
		// (set) Token: 0x0601EDCB RID: 126411 RVA: 0x002DDE5A File Offset: 0x002DC05A
		public unsafe FGuid ObjectGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorBindingInfo.__PropertyOffset_ObjectGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorBindingInfo.__PropertyOffset_ObjectGUID) = value;
			}
		}

		// Token: 0x0601EDCC RID: 126412 RVA: 0x002DDE6F File Offset: 0x002DC06F
		public FActorBindingInfo()
		{
		}

		// Token: 0x0601EDCD RID: 126413 RVA: 0x002DDE77 File Offset: 0x002DC077
		public FActorBindingInfo([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Actor, FGuid ObjectGUID)
		{
			this.Actor = Actor;
			this.ObjectGUID = ObjectGUID;
		}

		// Token: 0x0601EDCE RID: 126414 RVA: 0x002DDE8D File Offset: 0x002DC08D
		protected override IntPtr GetUStructPtr()
		{
			return FActorBindingInfo.StaticStruct();
		}

		// Token: 0x0601EDCF RID: 126415 RVA: 0x002DDE99 File Offset: 0x002DC099
		[NullableContext(2)]
		public FActorBindingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDD0 RID: 126416 RVA: 0x002DDEA3 File Offset: 0x002DC0A3
		public FActorBindingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDD1 RID: 126417 RVA: 0x002DDEAE File Offset: 0x002DC0AE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorBindingInfo(Pointer, false, true);
		}

		// Token: 0x0601EDD2 RID: 126418 RVA: 0x002DDEB8 File Offset: 0x002DC0B8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorBindingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010AC9 RID: 68297
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.ActorBindingInfo";

		// Token: 0x04010ACA RID: 68298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010ACB RID: 68299
		internal static int __PropertyOffset_Actor;

		// Token: 0x04010ACC RID: 68300
		internal static int __PropertyOffset_ObjectGUID;
	}
}
