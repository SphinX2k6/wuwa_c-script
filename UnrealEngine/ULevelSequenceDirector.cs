using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000642 RID: 1602
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceDirector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class ULevelSequenceDirector : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008D18 RID: 36120 RVA: 0x000D4374 File Offset: 0x000D2574
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequenceDirector._ClassPtr;
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x000D4380 File Offset: 0x000D2580
		public ULevelSequenceDirector() : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceDirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x000D43A8 File Offset: 0x000D25A8
		[NullableContext(1)]
		public ULevelSequenceDirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceDirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x000D43DB File Offset: 0x000D25DB
		// (set) Token: 0x06008D1C RID: 36124 RVA: 0x000D43EF File Offset: 0x000D25EF
		[Nullable(2)]
		public unsafe ULevelSequencePlayer Player
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequenceDirector.__PropertyOffset_Player);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelSequenceDirector.__PropertyOffset_Player, value);
			}
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x000D4404 File Offset: 0x000D2604
		public virtual void OnCreated()
		{
			ULevelSequenceDirector.__OnCreated_Internal(base.NativePtr);
		}

		// Token: 0x06008D1E RID: 36126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCreated_Internal(IntPtr @this);

		// Token: 0x06008D1F RID: 36127 RVA: 0x000D4411 File Offset: 0x000D2611
		static ULevelSequenceDirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceDirector");
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x000D441F File Offset: 0x000D261F
		protected ULevelSequenceDirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D6C RID: 15724
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceDirector";

		// Token: 0x04003D6D RID: 15725
		private static IntPtr _ClassPtr;

		// Token: 0x04003D6E RID: 15726
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D6F RID: 15727
		internal static int __PropertyOffset_Player;
	}
}
