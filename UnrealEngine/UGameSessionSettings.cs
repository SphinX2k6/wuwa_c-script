using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079C RID: 1948
	[UnrealObjectPath("/Script/EngineSettings.GameSessionSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UGameSessionSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006583 RID: 25987 RVA: 0x000918E1 File Offset: 0x0008FAE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameSessionSettings._ClassPtr;
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x000918F0 File Offset: 0x0008FAF0
		public UGameSessionSettings() : this(BuiltinUtils.AllocNativeUObject(UGameSessionSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x00091918 File Offset: 0x0008FB18
		[NullableContext(1)]
		public UGameSessionSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameSessionSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06006586 RID: 25990 RVA: 0x0009194B File Offset: 0x0008FB4B
		// (set) Token: 0x06006587 RID: 25991 RVA: 0x0009195B File Offset: 0x0008FB5B
		public unsafe int MaxSpectators
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_MaxSpectators);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_MaxSpectators) = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06006588 RID: 25992 RVA: 0x0009196C File Offset: 0x0008FB6C
		// (set) Token: 0x06006589 RID: 25993 RVA: 0x0009197C File Offset: 0x0008FB7C
		public unsafe int MaxPlayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_MaxPlayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_MaxPlayers) = value;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600658A RID: 25994 RVA: 0x0009198D File Offset: 0x0008FB8D
		// (set) Token: 0x0600658B RID: 25995 RVA: 0x000919A6 File Offset: 0x0008FBA6
		public unsafe bool bRequiresPushToTalk
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_bRequiresPushToTalk) & UGameSessionSettings.__PropertyMask_bRequiresPushToTalk) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_bRequiresPushToTalk) = ((*(base.NativePtr + (IntPtr)UGameSessionSettings.__PropertyOffset_bRequiresPushToTalk) & ~UGameSessionSettings.__PropertyMask_bRequiresPushToTalk) | (value ? UGameSessionSettings.__PropertyMask_bRequiresPushToTalk : 0));
			}
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x000919D6 File Offset: 0x0008FBD6
		static UGameSessionSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.GameSessionSettings");
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x000919E4 File Offset: 0x0008FBE4
		protected UGameSessionSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003143 RID: 12611
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/EngineSettings.GameSessionSettings";

		// Token: 0x04003144 RID: 12612
		private static IntPtr _ClassPtr;

		// Token: 0x04003145 RID: 12613
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003146 RID: 12614
		internal static int __PropertyOffset_MaxSpectators;

		// Token: 0x04003147 RID: 12615
		internal static int __PropertyOffset_MaxPlayers;

		// Token: 0x04003148 RID: 12616
		internal static int __PropertyOffset_bRequiresPushToTalk;

		// Token: 0x04003149 RID: 12617
		internal static byte __PropertyMask_bRequiresPushToTalk;
	}
}
