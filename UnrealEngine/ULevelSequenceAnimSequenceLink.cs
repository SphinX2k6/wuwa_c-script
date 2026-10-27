using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB1 RID: 8113
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceAnimSequenceLink")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULevelSequenceAnimSequenceLink : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ECCF RID: 126159 RVA: 0x002DC787 File Offset: 0x002DA987
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequenceAnimSequenceLink._ClassPtr;
		}

		// Token: 0x0601ECD0 RID: 126160 RVA: 0x002DC794 File Offset: 0x002DA994
		public ULevelSequenceAnimSequenceLink() : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceAnimSequenceLink.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ECD1 RID: 126161 RVA: 0x002DC7BC File Offset: 0x002DA9BC
		public ULevelSequenceAnimSequenceLink(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceAnimSequenceLink.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007AAA RID: 31402
		// (get) Token: 0x0601ECD2 RID: 126162 RVA: 0x002DC7F0 File Offset: 0x002DA9F0
		// (set) Token: 0x0601ECD3 RID: 126163 RVA: 0x002DC829 File Offset: 0x002DAA29
		public TArray<FLevelSequenceAnimSequenceLinkItem> AnimSequenceLinks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLevelSequenceAnimSequenceLinkItem> result;
				if ((result = this._AnimSequenceLinks) == null)
				{
					result = (this._AnimSequenceLinks = new TArray<FLevelSequenceAnimSequenceLinkItem>(base.NativePtr + (IntPtr)ULevelSequenceAnimSequenceLink.__PropertyOffset_AnimSequenceLinks, this));
				}
				return result;
			}
			set
			{
				this.AnimSequenceLinks.CopyAssign(value);
			}
		}

		// Token: 0x0601ECD4 RID: 126164 RVA: 0x002DC837 File Offset: 0x002DAA37
		static ULevelSequenceAnimSequenceLink()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceAnimSequenceLink");
		}

		// Token: 0x0601ECD5 RID: 126165 RVA: 0x002DC845 File Offset: 0x002DAA45
		protected ULevelSequenceAnimSequenceLink(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A5E RID: 68190
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceAnimSequenceLink";

		// Token: 0x04010A5F RID: 68191
		private static IntPtr _ClassPtr;

		// Token: 0x04010A60 RID: 68192
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A61 RID: 68193
		internal static int __PropertyOffset_AnimSequenceLinks;

		// Token: 0x04010A62 RID: 68194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLevelSequenceAnimSequenceLinkItem> _AnimSequenceLinks;
	}
}
