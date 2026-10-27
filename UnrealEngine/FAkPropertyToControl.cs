using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000236 RID: 566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkPropertyToControl")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAkPropertyToControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600210F RID: 8463 RVA: 0x000311DC File Offset: 0x0002F3DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkPropertyToControl._ScriptStructPtr != 0) ? FAkPropertyToControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkPropertyToControl", ref FAkPropertyToControl._ScriptStructPtr);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x00031200 File Offset: 0x0002F400
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x00031214 File Offset: 0x0002F414
		public unsafe string ItemProperty
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkPropertyToControl.__PropertyOffset_ItemProperty)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkPropertyToControl.__PropertyOffset_ItemProperty)), value);
			}
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00031229 File Offset: 0x0002F429
		public FAkPropertyToControl()
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00031231 File Offset: 0x0002F431
		public FAkPropertyToControl(string ItemProperty)
		{
			this.ItemProperty = ItemProperty;
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00031240 File Offset: 0x0002F440
		protected override IntPtr GetUStructPtr()
		{
			return FAkPropertyToControl.StaticStruct();
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0003124C File Offset: 0x0002F44C
		[NullableContext(2)]
		public FAkPropertyToControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00031256 File Offset: 0x0002F456
		public FAkPropertyToControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00031261 File Offset: 0x0002F461
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkPropertyToControl(Pointer, false, true);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x0003126B File Offset: 0x0002F46B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkPropertyToControl(Pointer, MemoryOwner);
		}

		// Token: 0x04000B27 RID: 2855
		public const string __ObjectPath = "/Script/AkAudio.AkPropertyToControl";

		// Token: 0x04000B28 RID: 2856
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000B29 RID: 2857
		internal static int __PropertyOffset_ItemProperty;
	}
}
