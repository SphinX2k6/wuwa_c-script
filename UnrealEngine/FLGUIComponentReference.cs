using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002030 RID: 8240
	[UnrealObjectPath("/Script/LGUI.LGUIComponentReference")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FLGUIComponentReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F2CD RID: 127693 RVA: 0x002E488C File Offset: 0x002E2A8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIComponentReference._ScriptStructPtr != 0) ? FLGUIComponentReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIComponentReference", ref FLGUIComponentReference._ScriptStructPtr);
		}

		// Token: 0x17007BA1 RID: 31649
		// (get) Token: 0x0601F2CE RID: 127694 RVA: 0x002E48B0 File Offset: 0x002E2AB0
		// (set) Token: 0x0601F2CF RID: 127695 RVA: 0x002E48C4 File Offset: 0x002E2AC4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> targetActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_targetActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_targetActor) = value;
			}
		}

		// Token: 0x17007BA2 RID: 31650
		// (get) Token: 0x0601F2D0 RID: 127696 RVA: 0x002E48D9 File Offset: 0x002E2AD9
		// (set) Token: 0x0601F2D1 RID: 127697 RVA: 0x002E48ED File Offset: 0x002E2AED
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UActorComponent> targetComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_targetComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_targetComponentClass) = value;
			}
		}

		// Token: 0x17007BA3 RID: 31651
		// (get) Token: 0x0601F2D2 RID: 127698 RVA: 0x002E4902 File Offset: 0x002E2B02
		// (set) Token: 0x0601F2D3 RID: 127699 RVA: 0x002E4916 File Offset: 0x002E2B16
		public unsafe FName targetComonentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_targetComonentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_targetComonentName) = value;
			}
		}

		// Token: 0x17007BA4 RID: 31652
		// (get) Token: 0x0601F2D4 RID: 127700 RVA: 0x002E492B File Offset: 0x002E2B2B
		// (set) Token: 0x0601F2D5 RID: 127701 RVA: 0x002E493F File Offset: 0x002E2B3F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UActorComponent> componentInstance
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_componentInstance);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIComponentReference.__PropertyOffset_componentInstance) = value;
			}
		}

		// Token: 0x0601F2D6 RID: 127702 RVA: 0x002E4954 File Offset: 0x002E2B54
		public FLGUIComponentReference()
		{
		}

		// Token: 0x0601F2D7 RID: 127703 RVA: 0x002E495C File Offset: 0x002E2B5C
		public FLGUIComponentReference([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> targetActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> targetComponentClass, FName targetComonentName, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UActorComponent> componentInstance)
		{
			this.targetActor = targetActor;
			this.targetComponentClass = targetComponentClass;
			this.targetComonentName = targetComonentName;
			this.componentInstance = componentInstance;
		}

		// Token: 0x0601F2D8 RID: 127704 RVA: 0x002E4981 File Offset: 0x002E2B81
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIComponentReference.StaticStruct();
		}

		// Token: 0x0601F2D9 RID: 127705 RVA: 0x002E498D File Offset: 0x002E2B8D
		[NullableContext(2)]
		public FLGUIComponentReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F2DA RID: 127706 RVA: 0x002E4997 File Offset: 0x002E2B97
		public FLGUIComponentReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F2DB RID: 127707 RVA: 0x002E49A2 File Offset: 0x002E2BA2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIComponentReference(Pointer, false, true);
		}

		// Token: 0x0601F2DC RID: 127708 RVA: 0x002E49AC File Offset: 0x002E2BAC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIComponentReference(Pointer, MemoryOwner);
		}

		// Token: 0x04010E04 RID: 69124
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIComponentReference";

		// Token: 0x04010E05 RID: 69125
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010E06 RID: 69126
		internal static int __PropertyOffset_targetActor;

		// Token: 0x04010E07 RID: 69127
		internal static int __PropertyOffset_targetComponentClass;

		// Token: 0x04010E08 RID: 69128
		internal static int __PropertyOffset_targetComonentName;

		// Token: 0x04010E09 RID: 69129
		internal static int __PropertyOffset_componentInstance;
	}
}
