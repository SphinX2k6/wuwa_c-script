using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001127 RID: 4391
	[UnrealObjectPath("/Script/Engine.SoundClassAdjuster")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoundClassAdjuster : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010105 RID: 65797 RVA: 0x0017AA5B File Offset: 0x00178C5B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundClassAdjuster._ScriptStructPtr != 0) ? FSoundClassAdjuster._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundClassAdjuster", ref FSoundClassAdjuster._ScriptStructPtr);
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06010106 RID: 65798 RVA: 0x0017AA7F File Offset: 0x00178C7F
		// (set) Token: 0x06010107 RID: 65799 RVA: 0x0017AA93 File Offset: 0x00178C93
		[Nullable(2)]
		public unsafe USoundClass SoundClassObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundClass>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundClassAdjuster.__PropertyOffset_SoundClassObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundClassAdjuster.__PropertyOffset_SoundClassObject, value);
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06010108 RID: 65800 RVA: 0x0017AAA8 File Offset: 0x00178CA8
		// (set) Token: 0x06010109 RID: 65801 RVA: 0x0017AAB8 File Offset: 0x00178CB8
		public unsafe float VolumeAdjuster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_VolumeAdjuster);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_VolumeAdjuster) = value;
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0601010A RID: 65802 RVA: 0x0017AAC9 File Offset: 0x00178CC9
		// (set) Token: 0x0601010B RID: 65803 RVA: 0x0017AAD9 File Offset: 0x00178CD9
		public unsafe float PitchAdjuster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_PitchAdjuster);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_PitchAdjuster) = value;
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0601010C RID: 65804 RVA: 0x0017AAEA File Offset: 0x00178CEA
		// (set) Token: 0x0601010D RID: 65805 RVA: 0x0017AAFA File Offset: 0x00178CFA
		public unsafe float LowPassFilterFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_LowPassFilterFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_LowPassFilterFrequency) = value;
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0601010E RID: 65806 RVA: 0x0017AB0B File Offset: 0x00178D0B
		// (set) Token: 0x0601010F RID: 65807 RVA: 0x0017AB24 File Offset: 0x00178D24
		public unsafe bool bApplyToChildren
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_bApplyToChildren) & FSoundClassAdjuster.__PropertyMask_bApplyToChildren) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_bApplyToChildren) = ((*(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_bApplyToChildren) & ~FSoundClassAdjuster.__PropertyMask_bApplyToChildren) | (value ? FSoundClassAdjuster.__PropertyMask_bApplyToChildren : 0));
			}
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x06010110 RID: 65808 RVA: 0x0017AB54 File Offset: 0x00178D54
		// (set) Token: 0x06010111 RID: 65809 RVA: 0x0017AB64 File Offset: 0x00178D64
		public unsafe float VoiceCenterChannelVolumeAdjuster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_VoiceCenterChannelVolumeAdjuster);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundClassAdjuster.__PropertyOffset_VoiceCenterChannelVolumeAdjuster) = value;
			}
		}

		// Token: 0x06010112 RID: 65810 RVA: 0x0017AB75 File Offset: 0x00178D75
		public FSoundClassAdjuster()
		{
		}

		// Token: 0x06010113 RID: 65811 RVA: 0x0017AB7D File Offset: 0x00178D7D
		[NullableContext(1)]
		public FSoundClassAdjuster(USoundClass SoundClassObject, float VolumeAdjuster, float PitchAdjuster, float LowPassFilterFrequency, bool bApplyToChildren, float VoiceCenterChannelVolumeAdjuster)
		{
			this.SoundClassObject = SoundClassObject;
			this.VolumeAdjuster = VolumeAdjuster;
			this.PitchAdjuster = PitchAdjuster;
			this.LowPassFilterFrequency = LowPassFilterFrequency;
			this.bApplyToChildren = bApplyToChildren;
			this.VoiceCenterChannelVolumeAdjuster = VoiceCenterChannelVolumeAdjuster;
		}

		// Token: 0x06010114 RID: 65812 RVA: 0x0017ABB2 File Offset: 0x00178DB2
		protected override IntPtr GetUStructPtr()
		{
			return FSoundClassAdjuster.StaticStruct();
		}

		// Token: 0x06010115 RID: 65813 RVA: 0x0017ABBE File Offset: 0x00178DBE
		[NullableContext(2)]
		public FSoundClassAdjuster(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010116 RID: 65814 RVA: 0x0017ABC8 File Offset: 0x00178DC8
		public FSoundClassAdjuster(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010117 RID: 65815 RVA: 0x0017ABD3 File Offset: 0x00178DD3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundClassAdjuster(Pointer, false, true);
		}

		// Token: 0x06010118 RID: 65816 RVA: 0x0017ABDD File Offset: 0x00178DDD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundClassAdjuster(Pointer, MemoryOwner);
		}

		// Token: 0x04008A2D RID: 35373
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundClassAdjuster";

		// Token: 0x04008A2E RID: 35374
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008A2F RID: 35375
		internal static int __PropertyOffset_SoundClassObject;

		// Token: 0x04008A30 RID: 35376
		internal static int __PropertyOffset_VolumeAdjuster;

		// Token: 0x04008A31 RID: 35377
		internal static int __PropertyOffset_PitchAdjuster;

		// Token: 0x04008A32 RID: 35378
		internal static int __PropertyOffset_LowPassFilterFrequency;

		// Token: 0x04008A33 RID: 35379
		internal static int __PropertyOffset_bApplyToChildren;

		// Token: 0x04008A34 RID: 35380
		internal static byte __PropertyMask_bApplyToChildren;

		// Token: 0x04008A35 RID: 35381
		internal static int __PropertyOffset_VoiceCenterChannelVolumeAdjuster;
	}
}
