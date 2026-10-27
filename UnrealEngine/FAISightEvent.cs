using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000110 RID: 272
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISightEvent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAISightEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600142A RID: 5162 RVA: 0x0001DC4A File Offset: 0x0001BE4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAISightEvent._ScriptStructPtr != 0) ? FAISightEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AISightEvent", ref FAISightEvent._ScriptStructPtr);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0001DC6E File Offset: 0x0001BE6E
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x0001DC82 File Offset: 0x0001BE82
		public unsafe AActor SeenActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAISightEvent.__PropertyOffset_SeenActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAISightEvent.__PropertyOffset_SeenActor, value);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0001DC97 File Offset: 0x0001BE97
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x0001DCAB File Offset: 0x0001BEAB
		public unsafe AActor Observer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAISightEvent.__PropertyOffset_Observer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAISightEvent.__PropertyOffset_Observer, value);
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		public FAISightEvent()
		{
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		[NullableContext(1)]
		public FAISightEvent(AActor SeenActor, AActor Observer)
		{
			this.SeenActor = SeenActor;
			this.Observer = Observer;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0001DCDE File Offset: 0x0001BEDE
		protected override IntPtr GetUStructPtr()
		{
			return FAISightEvent.StaticStruct();
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0001DCEA File Offset: 0x0001BEEA
		public FAISightEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
		public FAISightEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0001DCFF File Offset: 0x0001BEFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAISightEvent(Pointer, false, true);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0001DD09 File Offset: 0x0001BF09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAISightEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040003F7 RID: 1015
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AISightEvent";

		// Token: 0x040003F8 RID: 1016
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003F9 RID: 1017
		internal static int __PropertyOffset_SeenActor;

		// Token: 0x040003FA RID: 1018
		internal static int __PropertyOffset_Observer;
	}
}
