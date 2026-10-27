using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FA9 RID: 8105
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.AnimSequenceLevelSequenceLink")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAnimSequenceLevelSequenceLink : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC0C RID: 125964 RVA: 0x002DB7E1 File Offset: 0x002D99E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSequenceLevelSequenceLink._ClassPtr;
		}

		// Token: 0x0601EC0D RID: 125965 RVA: 0x002DB7F0 File Offset: 0x002D99F0
		public UAnimSequenceLevelSequenceLink() : this(BuiltinUtils.AllocNativeUObject(UAnimSequenceLevelSequenceLink.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC0E RID: 125966 RVA: 0x002DB818 File Offset: 0x002D9A18
		public UAnimSequenceLevelSequenceLink(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSequenceLevelSequenceLink.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A80 RID: 31360
		// (get) Token: 0x0601EC0F RID: 125967 RVA: 0x002DB84B File Offset: 0x002D9A4B
		// (set) Token: 0x0601EC10 RID: 125968 RVA: 0x002DB85F File Offset: 0x002D9A5F
		public unsafe FGuid SkelTrackGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceLevelSequenceLink.__PropertyOffset_SkelTrackGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceLevelSequenceLink.__PropertyOffset_SkelTrackGuid) = value;
			}
		}

		// Token: 0x17007A81 RID: 31361
		// (get) Token: 0x0601EC11 RID: 125969 RVA: 0x002DB874 File Offset: 0x002D9A74
		// (set) Token: 0x0601EC12 RID: 125970 RVA: 0x002DB8AD File Offset: 0x002D9AAD
		public FSoftObjectPath PathToLevelSequence
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PathToLevelSequence) == null)
				{
					result = (this._PathToLevelSequence = new FSoftObjectPath(base.NativePtr + (IntPtr)UAnimSequenceLevelSequenceLink.__PropertyOffset_PathToLevelSequence, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAnimSequenceLevelSequenceLink.__PropertyOffset_PathToLevelSequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EC13 RID: 125971 RVA: 0x002DB8CE File Offset: 0x002D9ACE
		static UAnimSequenceLevelSequenceLink()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.AnimSequenceLevelSequenceLink");
		}

		// Token: 0x0601EC14 RID: 125972 RVA: 0x002DB8DC File Offset: 0x002D9ADC
		protected UAnimSequenceLevelSequenceLink(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A08 RID: 68104
		public new const string __ObjectPath = "/Script/LevelSequence.AnimSequenceLevelSequenceLink";

		// Token: 0x04010A09 RID: 68105
		private static IntPtr _ClassPtr;

		// Token: 0x04010A0A RID: 68106
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A0B RID: 68107
		internal static int __PropertyOffset_SkelTrackGuid;

		// Token: 0x04010A0C RID: 68108
		internal static int __PropertyOffset_PathToLevelSequence;

		// Token: 0x04010A0D RID: 68109
		[Nullable(2)]
		private FSoftObjectPath _PathToLevelSequence;
	}
}
