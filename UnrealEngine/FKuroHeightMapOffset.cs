using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B21 RID: 6945
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHeightMapOffset")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroHeightMapOffset : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A2A9 RID: 107177 RVA: 0x0026A50C File Offset: 0x0026870C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHeightMapOffset._ScriptStructPtr != 0) ? FKuroHeightMapOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroHeightMapOffset", ref FKuroHeightMapOffset._ScriptStructPtr);
		}

		// Token: 0x17006932 RID: 26930
		// (get) Token: 0x0601A2AA RID: 107178 RVA: 0x0026A530 File Offset: 0x00268730
		// (set) Token: 0x0601A2AB RID: 107179 RVA: 0x0026A540 File Offset: 0x00268740
		public unsafe float ShotHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHeightMapOffset.__PropertyOffset_ShotHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHeightMapOffset.__PropertyOffset_ShotHeight) = value;
			}
		}

		// Token: 0x0601A2AC RID: 107180 RVA: 0x0026A551 File Offset: 0x00268751
		public FKuroHeightMapOffset()
		{
		}

		// Token: 0x0601A2AD RID: 107181 RVA: 0x0026A559 File Offset: 0x00268759
		public FKuroHeightMapOffset(float ShotHeight)
		{
			this.ShotHeight = ShotHeight;
		}

		// Token: 0x0601A2AE RID: 107182 RVA: 0x0026A568 File Offset: 0x00268768
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHeightMapOffset.StaticStruct();
		}

		// Token: 0x0601A2AF RID: 107183 RVA: 0x0026A574 File Offset: 0x00268774
		[NullableContext(2)]
		public FKuroHeightMapOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A2B0 RID: 107184 RVA: 0x0026A57E File Offset: 0x0026877E
		public FKuroHeightMapOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A2B1 RID: 107185 RVA: 0x0026A589 File Offset: 0x00268789
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHeightMapOffset(Pointer, false, true);
		}

		// Token: 0x0601A2B2 RID: 107186 RVA: 0x0026A593 File Offset: 0x00268793
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHeightMapOffset(Pointer, MemoryOwner);
		}

		// Token: 0x0400E37A RID: 58234
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHeightMapOffset";

		// Token: 0x0400E37B RID: 58235
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E37C RID: 58236
		internal static int __PropertyOffset_ShotHeight;
	}
}
