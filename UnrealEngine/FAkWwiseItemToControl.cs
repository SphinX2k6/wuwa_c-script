using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000262 RID: 610
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWwiseItemToControl")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAkWwiseItemToControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060023A9 RID: 9129 RVA: 0x00034D9E File Offset: 0x00032F9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWwiseItemToControl._ScriptStructPtr != 0) ? FAkWwiseItemToControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWwiseItemToControl", ref FAkWwiseItemToControl._ScriptStructPtr);
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x00034DC4 File Offset: 0x00032FC4
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x00034E07 File Offset: 0x00033007
		public FAkWwiseObjectDetails ItemPicked
		{
			get
			{
				base.FastCheckIsValid();
				FAkWwiseObjectDetails result;
				if ((result = this._ItemPicked) == null)
				{
					result = (this._ItemPicked = new FAkWwiseObjectDetails(base.NativePtr + (IntPtr)FAkWwiseItemToControl.__PropertyOffset_ItemPicked, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkWwiseObjectDetails.StaticStruct(), base.NativePtr + (IntPtr)FAkWwiseItemToControl.__PropertyOffset_ItemPicked, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x00034E28 File Offset: 0x00033028
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x00034E3C File Offset: 0x0003303C
		public unsafe string ItemPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseItemToControl.__PropertyOffset_ItemPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkWwiseItemToControl.__PropertyOffset_ItemPath)), value);
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00034E51 File Offset: 0x00033051
		public FAkWwiseItemToControl()
		{
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00034E59 File Offset: 0x00033059
		public FAkWwiseItemToControl(FAkWwiseObjectDetails ItemPicked, string ItemPath)
		{
			this.ItemPicked = ItemPicked;
			this.ItemPath = ItemPath;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00034E6F File Offset: 0x0003306F
		protected override IntPtr GetUStructPtr()
		{
			return FAkWwiseItemToControl.StaticStruct();
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00034E7B File Offset: 0x0003307B
		[NullableContext(2)]
		public FAkWwiseItemToControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00034E85 File Offset: 0x00033085
		public FAkWwiseItemToControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00034E90 File Offset: 0x00033090
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWwiseItemToControl(Pointer, false, true);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00034E9A File Offset: 0x0003309A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWwiseItemToControl(Pointer, MemoryOwner);
		}

		// Token: 0x04000C5C RID: 3164
		public const string __ObjectPath = "/Script/AkAudio.AkWwiseItemToControl";

		// Token: 0x04000C5D RID: 3165
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C5E RID: 3166
		internal static int __PropertyOffset_ItemPicked;

		// Token: 0x04000C5F RID: 3167
		[Nullable(2)]
		private FAkWwiseObjectDetails _ItemPicked;

		// Token: 0x04000C60 RID: 3168
		internal static int __PropertyOffset_ItemPath;
	}
}
