using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200221C RID: 8732
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSubjectPreset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FLiveLinkSubjectPreset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021413 RID: 136211 RVA: 0x0031054A File Offset: 0x0030E74A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSubjectPreset._ScriptStructPtr != 0) ? FLiveLinkSubjectPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSubjectPreset", ref FLiveLinkSubjectPreset._ScriptStructPtr);
		}

		// Token: 0x170081CC RID: 33228
		// (get) Token: 0x06021414 RID: 136212 RVA: 0x00310570 File Offset: 0x0030E770
		// (set) Token: 0x06021415 RID: 136213 RVA: 0x003105B3 File Offset: 0x0030E7B3
		[Nullable(1)]
		public FLiveLinkSubjectKey Key
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLiveLinkSubjectKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FLiveLinkSubjectKey(base.NativePtr + (IntPtr)FLiveLinkSubjectPreset.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkSubjectKey.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkSubjectPreset.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170081CD RID: 33229
		// (get) Token: 0x06021416 RID: 136214 RVA: 0x003105D4 File Offset: 0x0030E7D4
		// (set) Token: 0x06021417 RID: 136215 RVA: 0x003105E8 File Offset: 0x0030E7E8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ULiveLinkRole> Role
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSubjectPreset.__PropertyOffset_Role);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSubjectPreset.__PropertyOffset_Role) = value;
			}
		}

		// Token: 0x170081CE RID: 33230
		// (get) Token: 0x06021418 RID: 136216 RVA: 0x003105FD File Offset: 0x0030E7FD
		// (set) Token: 0x06021419 RID: 136217 RVA: 0x00310611 File Offset: 0x0030E811
		public unsafe ULiveLinkSubjectSettings Settings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULiveLinkSubjectSettings>(base.NativePtr / (IntPtr)sizeof(void*) + FLiveLinkSubjectPreset.__PropertyOffset_Settings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLiveLinkSubjectPreset.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x170081CF RID: 33231
		// (get) Token: 0x0602141A RID: 136218 RVA: 0x00310626 File Offset: 0x0030E826
		// (set) Token: 0x0602141B RID: 136219 RVA: 0x0031063A File Offset: 0x0030E83A
		public unsafe ULiveLinkVirtualSubject VirtualSubject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULiveLinkVirtualSubject>(base.NativePtr / (IntPtr)sizeof(void*) + FLiveLinkSubjectPreset.__PropertyOffset_VirtualSubject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLiveLinkSubjectPreset.__PropertyOffset_VirtualSubject, value);
			}
		}

		// Token: 0x170081D0 RID: 33232
		// (get) Token: 0x0602141C RID: 136220 RVA: 0x0031064F File Offset: 0x0030E84F
		// (set) Token: 0x0602141D RID: 136221 RVA: 0x0031065F File Offset: 0x0030E85F
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSubjectPreset.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSubjectPreset.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602141E RID: 136222 RVA: 0x00310670 File Offset: 0x0030E870
		public FLiveLinkSubjectPreset()
		{
		}

		// Token: 0x0602141F RID: 136223 RVA: 0x00310678 File Offset: 0x0030E878
		[NullableContext(1)]
		public FLiveLinkSubjectPreset(FLiveLinkSubjectKey Key, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULiveLinkRole> Role, ULiveLinkSubjectSettings Settings, ULiveLinkVirtualSubject VirtualSubject, bool bEnabled)
		{
			this.Key = Key;
			this.Role = Role;
			this.Settings = Settings;
			this.VirtualSubject = VirtualSubject;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06021420 RID: 136224 RVA: 0x003106A5 File Offset: 0x0030E8A5
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSubjectPreset.StaticStruct();
		}

		// Token: 0x06021421 RID: 136225 RVA: 0x003106B1 File Offset: 0x0030E8B1
		public FLiveLinkSubjectPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021422 RID: 136226 RVA: 0x003106BB File Offset: 0x0030E8BB
		public FLiveLinkSubjectPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021423 RID: 136227 RVA: 0x003106C6 File Offset: 0x0030E8C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSubjectPreset(Pointer, false, true);
		}

		// Token: 0x06021424 RID: 136228 RVA: 0x003106D0 File Offset: 0x0030E8D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSubjectPreset(Pointer, MemoryOwner);
		}

		// Token: 0x04011BCC RID: 72652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSubjectPreset";

		// Token: 0x04011BCD RID: 72653
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BCE RID: 72654
		internal static int __PropertyOffset_Key;

		// Token: 0x04011BCF RID: 72655
		private FLiveLinkSubjectKey _Key;

		// Token: 0x04011BD0 RID: 72656
		internal static int __PropertyOffset_Role;

		// Token: 0x04011BD1 RID: 72657
		internal static int __PropertyOffset_Settings;

		// Token: 0x04011BD2 RID: 72658
		internal static int __PropertyOffset_VirtualSubject;

		// Token: 0x04011BD3 RID: 72659
		internal static int __PropertyOffset_bEnabled;
	}
}
