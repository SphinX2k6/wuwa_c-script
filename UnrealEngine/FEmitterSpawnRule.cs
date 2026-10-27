using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016EC RID: 5868
	[UnrealObjectPath("/Script/KuroBulletCore.EmitterSpawnRule")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FEmitterSpawnRule : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015307 RID: 86791 RVA: 0x001F250A File Offset: 0x001F070A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterSpawnRule._ScriptStructPtr != 0) ? FEmitterSpawnRule._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.EmitterSpawnRule", ref FEmitterSpawnRule._ScriptStructPtr);
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x06015308 RID: 86792 RVA: 0x001F252E File Offset: 0x001F072E
		// (set) Token: 0x06015309 RID: 86793 RVA: 0x001F253E File Offset: 0x001F073E
		public unsafe EEmitterSpawnMode Mode
		{
			get
			{
				return (EEmitterSpawnMode)(*(base.NativePtr + (IntPtr)FEmitterSpawnRule.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterSpawnRule.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x0601530A RID: 86794 RVA: 0x001F254F File Offset: 0x001F074F
		// (set) Token: 0x0601530B RID: 86795 RVA: 0x001F2563 File Offset: 0x001F0763
		public unsafe FName ParentEmitterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterSpawnRule.__PropertyOffset_ParentEmitterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterSpawnRule.__PropertyOffset_ParentEmitterName) = value;
			}
		}

		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x0601530C RID: 86796 RVA: 0x001F2578 File Offset: 0x001F0778
		// (set) Token: 0x0601530D RID: 86797 RVA: 0x001F2588 File Offset: 0x001F0788
		public unsafe float DelaySeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterSpawnRule.__PropertyOffset_DelaySeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterSpawnRule.__PropertyOffset_DelaySeconds) = value;
			}
		}

		// Token: 0x0601530E RID: 86798 RVA: 0x001F2599 File Offset: 0x001F0799
		public FEmitterSpawnRule()
		{
		}

		// Token: 0x0601530F RID: 86799 RVA: 0x001F25A1 File Offset: 0x001F07A1
		public FEmitterSpawnRule(EEmitterSpawnMode Mode, FName ParentEmitterName, float DelaySeconds)
		{
			this.Mode = Mode;
			this.ParentEmitterName = ParentEmitterName;
			this.DelaySeconds = DelaySeconds;
		}

		// Token: 0x06015310 RID: 86800 RVA: 0x001F25BE File Offset: 0x001F07BE
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterSpawnRule.StaticStruct();
		}

		// Token: 0x06015311 RID: 86801 RVA: 0x001F25CA File Offset: 0x001F07CA
		[NullableContext(2)]
		public FEmitterSpawnRule(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015312 RID: 86802 RVA: 0x001F25D4 File Offset: 0x001F07D4
		public FEmitterSpawnRule(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015313 RID: 86803 RVA: 0x001F25DF File Offset: 0x001F07DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterSpawnRule(Pointer, false, true);
		}

		// Token: 0x06015314 RID: 86804 RVA: 0x001F25E9 File Offset: 0x001F07E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterSpawnRule(Pointer, MemoryOwner);
		}

		// Token: 0x0400B8DD RID: 47325
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.EmitterSpawnRule";

		// Token: 0x0400B8DE RID: 47326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B8DF RID: 47327
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400B8E0 RID: 47328
		internal static int __PropertyOffset_ParentEmitterName;

		// Token: 0x0400B8E1 RID: 47329
		internal static int __PropertyOffset_DelaySeconds;
	}
}
