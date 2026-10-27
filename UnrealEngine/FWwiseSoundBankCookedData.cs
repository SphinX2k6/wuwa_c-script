using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A77 RID: 10871
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseSoundBankCookedData")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FWwiseSoundBankCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028166 RID: 164198 RVA: 0x003D040B File Offset: 0x003CE60B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseSoundBankCookedData._ScriptStructPtr != 0) ? FWwiseSoundBankCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseFileHandler.WwiseSoundBankCookedData", ref FWwiseSoundBankCookedData._ScriptStructPtr);
		}

		// Token: 0x17009913 RID: 39187
		// (get) Token: 0x06028167 RID: 164199 RVA: 0x003D042F File Offset: 0x003CE62F
		// (set) Token: 0x06028168 RID: 164200 RVA: 0x003D043F File Offset: 0x003CE63F
		public unsafe int SoundBankId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_SoundBankId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_SoundBankId) = value;
			}
		}

		// Token: 0x17009914 RID: 39188
		// (get) Token: 0x06028169 RID: 164201 RVA: 0x003D0450 File Offset: 0x003CE650
		// (set) Token: 0x0602816A RID: 164202 RVA: 0x003D0464 File Offset: 0x003CE664
		public unsafe FName SoundBankPathName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_SoundBankPathName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_SoundBankPathName) = value;
			}
		}

		// Token: 0x17009915 RID: 39189
		// (get) Token: 0x0602816B RID: 164203 RVA: 0x003D0479 File Offset: 0x003CE679
		// (set) Token: 0x0602816C RID: 164204 RVA: 0x003D0489 File Offset: 0x003CE689
		public unsafe int MemoryAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_MemoryAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_MemoryAlignment) = value;
			}
		}

		// Token: 0x17009916 RID: 39190
		// (get) Token: 0x0602816D RID: 164205 RVA: 0x003D049A File Offset: 0x003CE69A
		// (set) Token: 0x0602816E RID: 164206 RVA: 0x003D04AA File Offset: 0x003CE6AA
		public unsafe bool bDeviceMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_bDeviceMemory) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_bDeviceMemory) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009917 RID: 39191
		// (get) Token: 0x0602816F RID: 164207 RVA: 0x003D04BB File Offset: 0x003CE6BB
		// (set) Token: 0x06028170 RID: 164208 RVA: 0x003D04CB File Offset: 0x003CE6CB
		public unsafe bool bContainsMedia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_bContainsMedia) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_bContainsMedia) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009918 RID: 39192
		// (get) Token: 0x06028171 RID: 164209 RVA: 0x003D04DC File Offset: 0x003CE6DC
		// (set) Token: 0x06028172 RID: 164210 RVA: 0x003D04EC File Offset: 0x003CE6EC
		public unsafe EWwiseSoundBankType SoundBankType
		{
			get
			{
				return (EWwiseSoundBankType)(*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_SoundBankType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_SoundBankType) = (byte)value;
			}
		}

		// Token: 0x17009919 RID: 39193
		// (get) Token: 0x06028173 RID: 164211 RVA: 0x003D04FD File Offset: 0x003CE6FD
		// (set) Token: 0x06028174 RID: 164212 RVA: 0x003D0511 File Offset: 0x003CE711
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseSoundBankCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x06028175 RID: 164213 RVA: 0x003D0526 File Offset: 0x003CE726
		public FWwiseSoundBankCookedData()
		{
		}

		// Token: 0x06028176 RID: 164214 RVA: 0x003D052E File Offset: 0x003CE72E
		public FWwiseSoundBankCookedData(int SoundBankId, FName SoundBankPathName, int MemoryAlignment, bool bDeviceMemory, bool bContainsMedia, EWwiseSoundBankType SoundBankType, FName DebugName)
		{
			this.SoundBankId = SoundBankId;
			this.SoundBankPathName = SoundBankPathName;
			this.MemoryAlignment = MemoryAlignment;
			this.bDeviceMemory = bDeviceMemory;
			this.bContainsMedia = bContainsMedia;
			this.SoundBankType = SoundBankType;
			this.DebugName = DebugName;
		}

		// Token: 0x06028177 RID: 164215 RVA: 0x003D056B File Offset: 0x003CE76B
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseSoundBankCookedData.StaticStruct();
		}

		// Token: 0x06028178 RID: 164216 RVA: 0x003D0577 File Offset: 0x003CE777
		[NullableContext(2)]
		public FWwiseSoundBankCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028179 RID: 164217 RVA: 0x003D0581 File Offset: 0x003CE781
		public FWwiseSoundBankCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602817A RID: 164218 RVA: 0x003D058C File Offset: 0x003CE78C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseSoundBankCookedData(Pointer, false, true);
		}

		// Token: 0x0602817B RID: 164219 RVA: 0x003D0596 File Offset: 0x003CE796
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseSoundBankCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016000 RID: 90112
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseFileHandler.WwiseSoundBankCookedData";

		// Token: 0x04016001 RID: 90113
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016002 RID: 90114
		internal static int __PropertyOffset_SoundBankId;

		// Token: 0x04016003 RID: 90115
		internal static int __PropertyOffset_SoundBankPathName;

		// Token: 0x04016004 RID: 90116
		internal static int __PropertyOffset_MemoryAlignment;

		// Token: 0x04016005 RID: 90117
		internal static int __PropertyOffset_bDeviceMemory;

		// Token: 0x04016006 RID: 90118
		internal static int __PropertyOffset_bContainsMedia;

		// Token: 0x04016007 RID: 90119
		internal static int __PropertyOffset_SoundBankType;

		// Token: 0x04016008 RID: 90120
		internal static int __PropertyOffset_DebugName;
	}
}
