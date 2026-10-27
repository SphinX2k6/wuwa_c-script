using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001159 RID: 4441
	[UnrealObjectPath("/Script/Engine.SoundTrackKey")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSoundTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601039D RID: 66461 RVA: 0x0017E891 File Offset: 0x0017CA91
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundTrackKey._ScriptStructPtr != 0) ? FSoundTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundTrackKey", ref FSoundTrackKey._ScriptStructPtr);
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x0601039E RID: 66462 RVA: 0x0017E8B5 File Offset: 0x0017CAB5
		// (set) Token: 0x0601039F RID: 66463 RVA: 0x0017E8C5 File Offset: 0x0017CAC5
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundTrackKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundTrackKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x060103A0 RID: 66464 RVA: 0x0017E8D6 File Offset: 0x0017CAD6
		// (set) Token: 0x060103A1 RID: 66465 RVA: 0x0017E8E6 File Offset: 0x0017CAE6
		public unsafe float Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundTrackKey.__PropertyOffset_Volume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundTrackKey.__PropertyOffset_Volume) = value;
			}
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x060103A2 RID: 66466 RVA: 0x0017E8F7 File Offset: 0x0017CAF7
		// (set) Token: 0x060103A3 RID: 66467 RVA: 0x0017E907 File Offset: 0x0017CB07
		public unsafe float Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundTrackKey.__PropertyOffset_Pitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundTrackKey.__PropertyOffset_Pitch) = value;
			}
		}

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x060103A4 RID: 66468 RVA: 0x0017E918 File Offset: 0x0017CB18
		// (set) Token: 0x060103A5 RID: 66469 RVA: 0x0017E92C File Offset: 0x0017CB2C
		[Nullable(2)]
		public unsafe USoundBase Sound
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundTrackKey.__PropertyOffset_Sound);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundTrackKey.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x060103A6 RID: 66470 RVA: 0x0017E941 File Offset: 0x0017CB41
		public FSoundTrackKey()
		{
		}

		// Token: 0x060103A7 RID: 66471 RVA: 0x0017E949 File Offset: 0x0017CB49
		[NullableContext(1)]
		public FSoundTrackKey(float Time, float Volume, float Pitch, USoundBase Sound)
		{
			this.Time = Time;
			this.Volume = Volume;
			this.Pitch = Pitch;
			this.Sound = Sound;
		}

		// Token: 0x060103A8 RID: 66472 RVA: 0x0017E96E File Offset: 0x0017CB6E
		protected override IntPtr GetUStructPtr()
		{
			return FSoundTrackKey.StaticStruct();
		}

		// Token: 0x060103A9 RID: 66473 RVA: 0x0017E97A File Offset: 0x0017CB7A
		[NullableContext(2)]
		public FSoundTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060103AA RID: 66474 RVA: 0x0017E984 File Offset: 0x0017CB84
		public FSoundTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060103AB RID: 66475 RVA: 0x0017E98F File Offset: 0x0017CB8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundTrackKey(Pointer, false, true);
		}

		// Token: 0x060103AC RID: 66476 RVA: 0x0017E999 File Offset: 0x0017CB99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x04008BAC RID: 35756
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundTrackKey";

		// Token: 0x04008BAD RID: 35757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BAE RID: 35758
		internal static int __PropertyOffset_Time;

		// Token: 0x04008BAF RID: 35759
		internal static int __PropertyOffset_Volume;

		// Token: 0x04008BB0 RID: 35760
		internal static int __PropertyOffset_Pitch;

		// Token: 0x04008BB1 RID: 35761
		internal static int __PropertyOffset_Sound;
	}
}
