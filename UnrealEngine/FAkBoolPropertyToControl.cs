using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001F5 RID: 501
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkBoolPropertyToControl")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAkBoolPropertyToControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001D76 RID: 7542 RVA: 0x0002BD6E File Offset: 0x00029F6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkBoolPropertyToControl._ScriptStructPtr != 0) ? FAkBoolPropertyToControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkBoolPropertyToControl", ref FAkBoolPropertyToControl._ScriptStructPtr);
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0002BD92 File Offset: 0x00029F92
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0002BDA6 File Offset: 0x00029FA6
		public unsafe string ItemProperty
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkBoolPropertyToControl.__PropertyOffset_ItemProperty)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkBoolPropertyToControl.__PropertyOffset_ItemProperty)), value);
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0002BDBB File Offset: 0x00029FBB
		public FAkBoolPropertyToControl()
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0002BDC3 File Offset: 0x00029FC3
		public FAkBoolPropertyToControl(string ItemProperty)
		{
			this.ItemProperty = ItemProperty;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0002BDD2 File Offset: 0x00029FD2
		protected override IntPtr GetUStructPtr()
		{
			return FAkBoolPropertyToControl.StaticStruct();
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0002BDDE File Offset: 0x00029FDE
		[NullableContext(2)]
		public FAkBoolPropertyToControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		public FAkBoolPropertyToControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0002BDF3 File Offset: 0x00029FF3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkBoolPropertyToControl(Pointer, false, true);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0002BDFD File Offset: 0x00029FFD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkBoolPropertyToControl(Pointer, MemoryOwner);
		}

		// Token: 0x040009B8 RID: 2488
		public const string __ObjectPath = "/Script/AkAudio.AkBoolPropertyToControl";

		// Token: 0x040009B9 RID: 2489
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009BA RID: 2490
		internal static int __PropertyOffset_ItemProperty;
	}
}
