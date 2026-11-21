using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000475 RID: 1141
	[UnrealObjectPath("/Script/KuroMovement.OverlapActorRecord")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FOverlapActorRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C5D RID: 27741 RVA: 0x0009DEE3 File Offset: 0x0009C0E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOverlapActorRecord._ScriptStructPtr != 0) ? FOverlapActorRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.OverlapActorRecord", ref FOverlapActorRecord._ScriptStructPtr);
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06006C5E RID: 27742 RVA: 0x0009DF07 File Offset: 0x0009C107
		// (set) Token: 0x06006C5F RID: 27743 RVA: 0x0009DF17 File Offset: 0x0009C117
		public unsafe ETriggerAreaType Area
		{
			get
			{
				return (ETriggerAreaType)(*(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_Area));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_Area) = (byte)value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06006C60 RID: 27744 RVA: 0x0009DF28 File Offset: 0x0009C128
		// (set) Token: 0x06006C61 RID: 27745 RVA: 0x0009DF3C File Offset: 0x0009C13C
		[Nullable(2)]
		public unsafe AActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FOverlapActorRecord.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FOverlapActorRecord.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06006C62 RID: 27746 RVA: 0x0009DF51 File Offset: 0x0009C151
		// (set) Token: 0x06006C63 RID: 27747 RVA: 0x0009DF61 File Offset: 0x0009C161
		public unsafe bool EnterOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_EnterOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapActorRecord.__PropertyOffset_EnterOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x0009DF72 File Offset: 0x0009C172
		public FOverlapActorRecord()
		{
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x0009DF7A File Offset: 0x0009C17A
		protected override IntPtr GetUStructPtr()
		{
			return FOverlapActorRecord.StaticStruct();
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x0009DF86 File Offset: 0x0009C186
		[NullableContext(2)]
		public FOverlapActorRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x0009DF90 File Offset: 0x0009C190
		public FOverlapActorRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x0009DF9B File Offset: 0x0009C19B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOverlapActorRecord(Pointer, false, true);
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x0009DFA5 File Offset: 0x0009C1A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOverlapActorRecord(Pointer, MemoryOwner);
		}

		// Token: 0x04002E49 RID: 11849
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.OverlapActorRecord";

		// Token: 0x04002E4A RID: 11850
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002E4B RID: 11851
		internal static int __PropertyOffset_Area;

		// Token: 0x04002E4C RID: 11852
		internal static int __PropertyOffset_Actor;

		// Token: 0x04002E4D RID: 11853
		internal static int __PropertyOffset_EnterOverlap;
	}
}
