using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011D9 RID: 4569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TextureLODSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UTextureLODSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D59 RID: 68953 RVA: 0x0018B89C File Offset: 0x00189A9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureLODSettings._ClassPtr;
		}

		// Token: 0x06010D5A RID: 68954 RVA: 0x0018B8A8 File Offset: 0x00189AA8
		public UTextureLODSettings() : this(BuiltinUtils.AllocNativeUObject(UTextureLODSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D5B RID: 68955 RVA: 0x0018B8D0 File Offset: 0x00189AD0
		public UTextureLODSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureLODSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x06010D5C RID: 68956 RVA: 0x0018B904 File Offset: 0x00189B04
		// (set) Token: 0x06010D5D RID: 68957 RVA: 0x0018B93D File Offset: 0x00189B3D
		public TArray<FTextureLODGroup> TextureLODGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTextureLODGroup> result;
				if ((result = this._TextureLODGroups) == null)
				{
					result = (this._TextureLODGroups = new TArray<FTextureLODGroup>(base.NativePtr + (IntPtr)UTextureLODSettings.__PropertyOffset_TextureLODGroups, this));
				}
				return result;
			}
			set
			{
				this.TextureLODGroups.CopyAssign(value);
			}
		}

		// Token: 0x06010D5E RID: 68958 RVA: 0x0018B94B File Offset: 0x00189B4B
		static UTextureLODSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureLODSettings");
		}

		// Token: 0x06010D5F RID: 68959 RVA: 0x0018B959 File Offset: 0x00189B59
		protected UTextureLODSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400903F RID: 36927
		public new const string __ObjectPath = "/Script/Engine.TextureLODSettings";

		// Token: 0x04009040 RID: 36928
		private static IntPtr _ClassPtr;

		// Token: 0x04009041 RID: 36929
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009042 RID: 36930
		internal static int __PropertyOffset_TextureLODGroups;

		// Token: 0x04009043 RID: 36931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTextureLODGroup> _TextureLODGroups;
	}
}
