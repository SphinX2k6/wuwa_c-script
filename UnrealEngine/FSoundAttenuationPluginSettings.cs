using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001123 RID: 4387
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundAttenuationPluginSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSoundAttenuationPluginSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010043 RID: 65603 RVA: 0x001794E9 File Offset: 0x001776E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundAttenuationPluginSettings._ScriptStructPtr != 0) ? FSoundAttenuationPluginSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundAttenuationPluginSettings", ref FSoundAttenuationPluginSettings._ScriptStructPtr);
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x06010044 RID: 65604 RVA: 0x00179510 File Offset: 0x00177710
		// (set) Token: 0x06010045 RID: 65605 RVA: 0x00179553 File Offset: 0x00177753
		public TArray<USpatializationPluginSourceSettingsBase> SpatializationPluginSettingsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USpatializationPluginSourceSettingsBase> result;
				if ((result = this._SpatializationPluginSettingsArray) == null)
				{
					result = (this._SpatializationPluginSettingsArray = new TArray<USpatializationPluginSourceSettingsBase>(base.NativePtr + (IntPtr)FSoundAttenuationPluginSettings.__PropertyOffset_SpatializationPluginSettingsArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpatializationPluginSettingsArray.CopyAssign(value);
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x06010046 RID: 65606 RVA: 0x00179564 File Offset: 0x00177764
		// (set) Token: 0x06010047 RID: 65607 RVA: 0x001795A7 File Offset: 0x001777A7
		public TArray<UOcclusionPluginSourceSettingsBase> OcclusionPluginSettingsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UOcclusionPluginSourceSettingsBase> result;
				if ((result = this._OcclusionPluginSettingsArray) == null)
				{
					result = (this._OcclusionPluginSettingsArray = new TArray<UOcclusionPluginSourceSettingsBase>(base.NativePtr + (IntPtr)FSoundAttenuationPluginSettings.__PropertyOffset_OcclusionPluginSettingsArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OcclusionPluginSettingsArray.CopyAssign(value);
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x06010048 RID: 65608 RVA: 0x001795B8 File Offset: 0x001777B8
		// (set) Token: 0x06010049 RID: 65609 RVA: 0x001795FB File Offset: 0x001777FB
		public TArray<UReverbPluginSourceSettingsBase> ReverbPluginSettingsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UReverbPluginSourceSettingsBase> result;
				if ((result = this._ReverbPluginSettingsArray) == null)
				{
					result = (this._ReverbPluginSettingsArray = new TArray<UReverbPluginSourceSettingsBase>(base.NativePtr + (IntPtr)FSoundAttenuationPluginSettings.__PropertyOffset_ReverbPluginSettingsArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReverbPluginSettingsArray.CopyAssign(value);
			}
		}

		// Token: 0x0601004A RID: 65610 RVA: 0x00179609 File Offset: 0x00177809
		public FSoundAttenuationPluginSettings()
		{
		}

		// Token: 0x0601004B RID: 65611 RVA: 0x00179611 File Offset: 0x00177811
		public FSoundAttenuationPluginSettings(TArray<USpatializationPluginSourceSettingsBase> SpatializationPluginSettingsArray, TArray<UOcclusionPluginSourceSettingsBase> OcclusionPluginSettingsArray, TArray<UReverbPluginSourceSettingsBase> ReverbPluginSettingsArray)
		{
			this.SpatializationPluginSettingsArray = SpatializationPluginSettingsArray;
			this.OcclusionPluginSettingsArray = OcclusionPluginSettingsArray;
			this.ReverbPluginSettingsArray = ReverbPluginSettingsArray;
		}

		// Token: 0x0601004C RID: 65612 RVA: 0x0017962E File Offset: 0x0017782E
		protected override IntPtr GetUStructPtr()
		{
			return FSoundAttenuationPluginSettings.StaticStruct();
		}

		// Token: 0x0601004D RID: 65613 RVA: 0x0017963A File Offset: 0x0017783A
		[NullableContext(2)]
		public FSoundAttenuationPluginSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601004E RID: 65614 RVA: 0x00179644 File Offset: 0x00177844
		public FSoundAttenuationPluginSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601004F RID: 65615 RVA: 0x0017964F File Offset: 0x0017784F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundAttenuationPluginSettings(Pointer, false, true);
		}

		// Token: 0x06010050 RID: 65616 RVA: 0x00179659 File Offset: 0x00177859
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundAttenuationPluginSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040089A9 RID: 35241
		public const string __ObjectPath = "/Script/Engine.SoundAttenuationPluginSettings";

		// Token: 0x040089AA RID: 35242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040089AB RID: 35243
		internal static int __PropertyOffset_SpatializationPluginSettingsArray;

		// Token: 0x040089AC RID: 35244
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USpatializationPluginSourceSettingsBase> _SpatializationPluginSettingsArray;

		// Token: 0x040089AD RID: 35245
		internal static int __PropertyOffset_OcclusionPluginSettingsArray;

		// Token: 0x040089AE RID: 35246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UOcclusionPluginSourceSettingsBase> _OcclusionPluginSettingsArray;

		// Token: 0x040089AF RID: 35247
		internal static int __PropertyOffset_ReverbPluginSettingsArray;

		// Token: 0x040089B0 RID: 35248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UReverbPluginSourceSettingsBase> _ReverbPluginSettingsArray;
	}
}
