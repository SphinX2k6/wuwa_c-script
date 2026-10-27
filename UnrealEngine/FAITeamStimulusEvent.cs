using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000119 RID: 281
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AITeamStimulusEvent")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAITeamStimulusEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x0001E706 File Offset: 0x0001C906
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAITeamStimulusEvent._ScriptStructPtr != 0) ? FAITeamStimulusEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AITeamStimulusEvent", ref FAITeamStimulusEvent._ScriptStructPtr);
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0001E72A File Offset: 0x0001C92A
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0001E73E File Offset: 0x0001C93E
		public unsafe AActor Broadcaster
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAITeamStimulusEvent.__PropertyOffset_Broadcaster);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAITeamStimulusEvent.__PropertyOffset_Broadcaster, value);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0001E753 File Offset: 0x0001C953
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0001E767 File Offset: 0x0001C967
		public unsafe AActor Enemy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAITeamStimulusEvent.__PropertyOffset_Enemy);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAITeamStimulusEvent.__PropertyOffset_Enemy, value);
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0001E77C File Offset: 0x0001C97C
		public FAITeamStimulusEvent()
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0001E784 File Offset: 0x0001C984
		[NullableContext(1)]
		public FAITeamStimulusEvent(AActor Broadcaster, AActor Enemy)
		{
			this.Broadcaster = Broadcaster;
			this.Enemy = Enemy;
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0001E79A File Offset: 0x0001C99A
		protected override IntPtr GetUStructPtr()
		{
			return FAITeamStimulusEvent.StaticStruct();
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0001E7A6 File Offset: 0x0001C9A6
		public FAITeamStimulusEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
		public FAITeamStimulusEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0001E7BB File Offset: 0x0001C9BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAITeamStimulusEvent(Pointer, false, true);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0001E7C5 File Offset: 0x0001C9C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAITeamStimulusEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04000437 RID: 1079
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AITeamStimulusEvent";

		// Token: 0x04000438 RID: 1080
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000439 RID: 1081
		internal static int __PropertyOffset_Broadcaster;

		// Token: 0x0400043A RID: 1082
		internal static int __PropertyOffset_Enemy;
	}
}
