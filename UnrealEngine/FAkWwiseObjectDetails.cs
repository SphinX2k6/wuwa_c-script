using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000263 RID: 611
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWwiseObjectDetails")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAkWwiseObjectDetails : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060023B5 RID: 9141 RVA: 0x00034EA3 File Offset: 0x000330A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWwiseObjectDetails._ScriptStructPtr != 0) ? FAkWwiseObjectDetails._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWwiseObjectDetails", ref FAkWwiseObjectDetails._ScriptStructPtr);
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x00034EC7 File Offset: 0x000330C7
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x00034EDB File Offset: 0x000330DB
		public unsafe string ItemName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseObjectDetails.__PropertyOffset_ItemName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseObjectDetails.__PropertyOffset_ItemName)), value);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x00034EF0 File Offset: 0x000330F0
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x00034F04 File Offset: 0x00033104
		public unsafe string ItemPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseObjectDetails.__PropertyOffset_ItemPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseObjectDetails.__PropertyOffset_ItemPath)), value);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x00034F19 File Offset: 0x00033119
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x00034F2D File Offset: 0x0003312D
		public unsafe string ItemId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseObjectDetails.__PropertyOffset_ItemId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseObjectDetails.__PropertyOffset_ItemId)), value);
			}
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00034F42 File Offset: 0x00033142
		public FAkWwiseObjectDetails()
		{
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00034F4A File Offset: 0x0003314A
		public FAkWwiseObjectDetails(string ItemName, string ItemPath, string ItemId)
		{
			this.ItemName = ItemName;
			this.ItemPath = ItemPath;
			this.ItemId = ItemId;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00034F67 File Offset: 0x00033167
		protected override IntPtr GetUStructPtr()
		{
			return FAkWwiseObjectDetails.StaticStruct();
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00034F73 File Offset: 0x00033173
		[NullableContext(2)]
		public FAkWwiseObjectDetails(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00034F7D File Offset: 0x0003317D
		public FAkWwiseObjectDetails(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00034F88 File Offset: 0x00033188
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWwiseObjectDetails(Pointer, false, true);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00034F92 File Offset: 0x00033192
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWwiseObjectDetails(Pointer, MemoryOwner);
		}

		// Token: 0x04000C61 RID: 3169
		public const string __ObjectPath = "/Script/AkAudio.AkWwiseObjectDetails";

		// Token: 0x04000C62 RID: 3170
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C63 RID: 3171
		internal static int __PropertyOffset_ItemName;

		// Token: 0x04000C64 RID: 3172
		internal static int __PropertyOffset_ItemPath;

		// Token: 0x04000C65 RID: 3173
		internal static int __PropertyOffset_ItemId;
	}
}
