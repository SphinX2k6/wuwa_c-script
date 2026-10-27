using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200201B RID: 8219
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LevelSequencerActor")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLevelSequencerActor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EF83 RID: 126851 RVA: 0x002E0E3E File Offset: 0x002DF03E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequencerActor._ScriptStructPtr != 0) ? FLevelSequencerActor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LevelSequencerActor", ref FLevelSequencerActor._ScriptStructPtr);
		}

		// Token: 0x17007B47 RID: 31559
		// (get) Token: 0x0601EF84 RID: 126852 RVA: 0x002E0E64 File Offset: 0x002DF064
		// (set) Token: 0x0601EF85 RID: 126853 RVA: 0x002E0EA7 File Offset: 0x002DF0A7
		public TArray<AUIBaseActor> TargetActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AUIBaseActor> result;
				if ((result = this._TargetActors) == null)
				{
					result = (this._TargetActors = new TArray<AUIBaseActor>(base.NativePtr + (IntPtr)FLevelSequencerActor.__PropertyOffset_TargetActors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetActors.CopyAssign(value);
			}
		}

		// Token: 0x17007B48 RID: 31560
		// (get) Token: 0x0601EF86 RID: 126854 RVA: 0x002E0EB5 File Offset: 0x002DF0B5
		// (set) Token: 0x0601EF87 RID: 126855 RVA: 0x002E0EC9 File Offset: 0x002DF0C9
		[Nullable(2)]
		public unsafe ALevelSequenceActor LvlSequencerActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelSequencerActor.__PropertyOffset_LvlSequencerActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelSequencerActor.__PropertyOffset_LvlSequencerActor, value);
			}
		}

		// Token: 0x0601EF88 RID: 126856 RVA: 0x002E0EDE File Offset: 0x002DF0DE
		public FLevelSequencerActor()
		{
		}

		// Token: 0x0601EF89 RID: 126857 RVA: 0x002E0EE6 File Offset: 0x002DF0E6
		public FLevelSequencerActor(TArray<AUIBaseActor> TargetActors, ALevelSequenceActor LvlSequencerActor)
		{
			this.TargetActors = TargetActors;
			this.LvlSequencerActor = LvlSequencerActor;
		}

		// Token: 0x0601EF8A RID: 126858 RVA: 0x002E0EFC File Offset: 0x002DF0FC
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequencerActor.StaticStruct();
		}

		// Token: 0x0601EF8B RID: 126859 RVA: 0x002E0F08 File Offset: 0x002DF108
		[NullableContext(2)]
		public FLevelSequencerActor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF8C RID: 126860 RVA: 0x002E0F12 File Offset: 0x002DF112
		public FLevelSequencerActor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF8D RID: 126861 RVA: 0x002E0F1D File Offset: 0x002DF11D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequencerActor(Pointer, false, true);
		}

		// Token: 0x0601EF8E RID: 126862 RVA: 0x002E0F27 File Offset: 0x002DF127
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequencerActor(Pointer, MemoryOwner);
		}

		// Token: 0x04010D62 RID: 68962
		public const string __ObjectPath = "/Script/LGUI.LevelSequencerActor";

		// Token: 0x04010D63 RID: 68963
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D64 RID: 68964
		internal static int __PropertyOffset_TargetActors;

		// Token: 0x04010D65 RID: 68965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AUIBaseActor> _TargetActors;

		// Token: 0x04010D66 RID: 68966
		internal static int __PropertyOffset_LvlSequencerActor;
	}
}
