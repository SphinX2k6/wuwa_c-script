using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A76 RID: 10870
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseMediaCookedData")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FWwiseMediaCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028150 RID: 164176 RVA: 0x003D0277 File Offset: 0x003CE477
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseMediaCookedData._ScriptStructPtr != 0) ? FWwiseMediaCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseFileHandler.WwiseMediaCookedData", ref FWwiseMediaCookedData._ScriptStructPtr);
		}

		// Token: 0x1700990C RID: 39180
		// (get) Token: 0x06028151 RID: 164177 RVA: 0x003D029B File Offset: 0x003CE49B
		// (set) Token: 0x06028152 RID: 164178 RVA: 0x003D02AB File Offset: 0x003CE4AB
		public unsafe int MediaId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_MediaId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_MediaId) = value;
			}
		}

		// Token: 0x1700990D RID: 39181
		// (get) Token: 0x06028153 RID: 164179 RVA: 0x003D02BC File Offset: 0x003CE4BC
		// (set) Token: 0x06028154 RID: 164180 RVA: 0x003D02D0 File Offset: 0x003CE4D0
		public unsafe FName MediaPathName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_MediaPathName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_MediaPathName) = value;
			}
		}

		// Token: 0x1700990E RID: 39182
		// (get) Token: 0x06028155 RID: 164181 RVA: 0x003D02E5 File Offset: 0x003CE4E5
		// (set) Token: 0x06028156 RID: 164182 RVA: 0x003D02F5 File Offset: 0x003CE4F5
		public unsafe int PrefetchSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_PrefetchSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_PrefetchSize) = value;
			}
		}

		// Token: 0x1700990F RID: 39183
		// (get) Token: 0x06028157 RID: 164183 RVA: 0x003D0306 File Offset: 0x003CE506
		// (set) Token: 0x06028158 RID: 164184 RVA: 0x003D0316 File Offset: 0x003CE516
		public unsafe int MemoryAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_MemoryAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_MemoryAlignment) = value;
			}
		}

		// Token: 0x17009910 RID: 39184
		// (get) Token: 0x06028159 RID: 164185 RVA: 0x003D0327 File Offset: 0x003CE527
		// (set) Token: 0x0602815A RID: 164186 RVA: 0x003D0337 File Offset: 0x003CE537
		public unsafe bool bDeviceMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_bDeviceMemory) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_bDeviceMemory) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009911 RID: 39185
		// (get) Token: 0x0602815B RID: 164187 RVA: 0x003D0348 File Offset: 0x003CE548
		// (set) Token: 0x0602815C RID: 164188 RVA: 0x003D0358 File Offset: 0x003CE558
		public unsafe bool bStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_bStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_bStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009912 RID: 39186
		// (get) Token: 0x0602815D RID: 164189 RVA: 0x003D0369 File Offset: 0x003CE569
		// (set) Token: 0x0602815E RID: 164190 RVA: 0x003D037D File Offset: 0x003CE57D
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseMediaCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x0602815F RID: 164191 RVA: 0x003D0392 File Offset: 0x003CE592
		public FWwiseMediaCookedData()
		{
		}

		// Token: 0x06028160 RID: 164192 RVA: 0x003D039A File Offset: 0x003CE59A
		public FWwiseMediaCookedData(int MediaId, FName MediaPathName, int PrefetchSize, int MemoryAlignment, bool bDeviceMemory, bool bStreaming, FName DebugName)
		{
			this.MediaId = MediaId;
			this.MediaPathName = MediaPathName;
			this.PrefetchSize = PrefetchSize;
			this.MemoryAlignment = MemoryAlignment;
			this.bDeviceMemory = bDeviceMemory;
			this.bStreaming = bStreaming;
			this.DebugName = DebugName;
		}

		// Token: 0x06028161 RID: 164193 RVA: 0x003D03D7 File Offset: 0x003CE5D7
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseMediaCookedData.StaticStruct();
		}

		// Token: 0x06028162 RID: 164194 RVA: 0x003D03E3 File Offset: 0x003CE5E3
		[NullableContext(2)]
		public FWwiseMediaCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028163 RID: 164195 RVA: 0x003D03ED File Offset: 0x003CE5ED
		public FWwiseMediaCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028164 RID: 164196 RVA: 0x003D03F8 File Offset: 0x003CE5F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseMediaCookedData(Pointer, false, true);
		}

		// Token: 0x06028165 RID: 164197 RVA: 0x003D0402 File Offset: 0x003CE602
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseMediaCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04015FF7 RID: 90103
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseFileHandler.WwiseMediaCookedData";

		// Token: 0x04015FF8 RID: 90104
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015FF9 RID: 90105
		internal static int __PropertyOffset_MediaId;

		// Token: 0x04015FFA RID: 90106
		internal static int __PropertyOffset_MediaPathName;

		// Token: 0x04015FFB RID: 90107
		internal static int __PropertyOffset_PrefetchSize;

		// Token: 0x04015FFC RID: 90108
		internal static int __PropertyOffset_MemoryAlignment;

		// Token: 0x04015FFD RID: 90109
		internal static int __PropertyOffset_bDeviceMemory;

		// Token: 0x04015FFE RID: 90110
		internal static int __PropertyOffset_bStreaming;

		// Token: 0x04015FFF RID: 90111
		internal static int __PropertyOffset_DebugName;
	}
}
