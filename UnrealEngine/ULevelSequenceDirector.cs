using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FBA RID: 8122
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceDirector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class ULevelSequenceDirector : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED39 RID: 126265 RVA: 0x002DD0A2 File Offset: 0x002DB2A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequenceDirector._ClassPtr;
		}

		// Token: 0x0601ED3A RID: 126266 RVA: 0x002DD0B0 File Offset: 0x002DB2B0
		public ULevelSequenceDirector() : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceDirector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED3B RID: 126267 RVA: 0x002DD0D8 File Offset: 0x002DB2D8
		[NullableContext(1)]
		public ULevelSequenceDirector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceDirector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007ABD RID: 31421
		// (get) Token: 0x0601ED3C RID: 126268 RVA: 0x002DD10B File Offset: 0x002DB30B
		// (set) Token: 0x0601ED3D RID: 126269 RVA: 0x002DD11F File Offset: 0x002DB31F
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

		// Token: 0x0601ED3E RID: 126270 RVA: 0x002DD134 File Offset: 0x002DB334
		public virtual void OnCreated()
		{
			ULevelSequenceDirector.__OnCreated_Internal(base.NativePtr);
		}

		// Token: 0x0601ED3F RID: 126271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCreated_Internal(IntPtr @this);

		// Token: 0x0601ED40 RID: 126272 RVA: 0x002DD141 File Offset: 0x002DB341
		static ULevelSequenceDirector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceDirector");
		}

		// Token: 0x0601ED41 RID: 126273 RVA: 0x002DD14F File Offset: 0x002DB34F
		protected ULevelSequenceDirector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A8F RID: 68239
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceDirector";

		// Token: 0x04010A90 RID: 68240
		private static IntPtr _ClassPtr;

		// Token: 0x04010A91 RID: 68241
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A92 RID: 68242
		internal static int __PropertyOffset_Player;
	}
}
