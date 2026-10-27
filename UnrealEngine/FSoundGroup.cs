using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001133 RID: 4403
	[UnrealObjectPath("/Script/Engine.SoundGroup")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoundGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060101C1 RID: 65985 RVA: 0x0017BC37 File Offset: 0x00179E37
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundGroup._ScriptStructPtr != 0) ? FSoundGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundGroup", ref FSoundGroup._ScriptStructPtr);
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x060101C2 RID: 65986 RVA: 0x0017BC5B File Offset: 0x00179E5B
		// (set) Token: 0x060101C3 RID: 65987 RVA: 0x0017BC6F File Offset: 0x00179E6F
		public unsafe TEnumAsByte<ESoundGroup> SoundGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_SoundGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_SoundGroup) = value;
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x060101C4 RID: 65988 RVA: 0x0017BC84 File Offset: 0x00179E84
		// (set) Token: 0x060101C5 RID: 65989 RVA: 0x0017BC98 File Offset: 0x00179E98
		[Nullable(1)]
		public unsafe string DisplayName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSoundGroup.__PropertyOffset_DisplayName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSoundGroup.__PropertyOffset_DisplayName)), value);
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x060101C6 RID: 65990 RVA: 0x0017BCAD File Offset: 0x00179EAD
		// (set) Token: 0x060101C7 RID: 65991 RVA: 0x0017BCC6 File Offset: 0x00179EC6
		public unsafe bool bAlwaysDecompressOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_bAlwaysDecompressOnLoad) & FSoundGroup.__PropertyMask_bAlwaysDecompressOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_bAlwaysDecompressOnLoad) = ((*(base.NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_bAlwaysDecompressOnLoad) & ~FSoundGroup.__PropertyMask_bAlwaysDecompressOnLoad) | (value ? FSoundGroup.__PropertyMask_bAlwaysDecompressOnLoad : 0));
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x060101C8 RID: 65992 RVA: 0x0017BCF6 File Offset: 0x00179EF6
		// (set) Token: 0x060101C9 RID: 65993 RVA: 0x0017BD06 File Offset: 0x00179F06
		public unsafe float DecompressedDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_DecompressedDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundGroup.__PropertyOffset_DecompressedDuration) = value;
			}
		}

		// Token: 0x060101CA RID: 65994 RVA: 0x0017BD17 File Offset: 0x00179F17
		public FSoundGroup()
		{
		}

		// Token: 0x060101CB RID: 65995 RVA: 0x0017BD1F File Offset: 0x00179F1F
		public FSoundGroup(TEnumAsByte<ESoundGroup> SoundGroup, [Nullable(1)] string DisplayName, bool bAlwaysDecompressOnLoad, float DecompressedDuration)
		{
			this.SoundGroup = SoundGroup;
			this.DisplayName = DisplayName;
			this.bAlwaysDecompressOnLoad = bAlwaysDecompressOnLoad;
			this.DecompressedDuration = DecompressedDuration;
		}

		// Token: 0x060101CC RID: 65996 RVA: 0x0017BD44 File Offset: 0x00179F44
		protected override IntPtr GetUStructPtr()
		{
			return FSoundGroup.StaticStruct();
		}

		// Token: 0x060101CD RID: 65997 RVA: 0x0017BD50 File Offset: 0x00179F50
		[NullableContext(2)]
		public FSoundGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060101CE RID: 65998 RVA: 0x0017BD5A File Offset: 0x00179F5A
		public FSoundGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060101CF RID: 65999 RVA: 0x0017BD65 File Offset: 0x00179F65
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundGroup(Pointer, false, true);
		}

		// Token: 0x060101D0 RID: 66000 RVA: 0x0017BD6F File Offset: 0x00179F6F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04008A9E RID: 35486
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundGroup";

		// Token: 0x04008A9F RID: 35487
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008AA0 RID: 35488
		internal static int __PropertyOffset_SoundGroup;

		// Token: 0x04008AA1 RID: 35489
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04008AA2 RID: 35490
		internal static int __PropertyOffset_bAlwaysDecompressOnLoad;

		// Token: 0x04008AA3 RID: 35491
		internal static byte __PropertyMask_bAlwaysDecompressOnLoad;

		// Token: 0x04008AA4 RID: 35492
		internal static int __PropertyOffset_DecompressedDuration;
	}
}
