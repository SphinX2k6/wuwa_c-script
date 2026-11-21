using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200019D RID: 413
	[UnrealObjectPath("/Script/Engine.CameraShakeDuration")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FCameraShakeDuration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x0002963D File Offset: 0x0002783D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraShakeDuration._ScriptStructPtr != 0) ? FCameraShakeDuration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraShakeDuration", ref FCameraShakeDuration._ScriptStructPtr);
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00029661 File Offset: 0x00027861
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x00029671 File Offset: 0x00027871
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00029682 File Offset: 0x00027882
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x00029692 File Offset: 0x00027892
		public unsafe ECameraShakeDurationType Type
		{
			get
			{
				return (ECameraShakeDurationType)(*(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000296A3 File Offset: 0x000278A3
		public FCameraShakeDuration()
		{
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000296AB File Offset: 0x000278AB
		protected override IntPtr GetUStructPtr()
		{
			return FCameraShakeDuration.StaticStruct();
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000296B7 File Offset: 0x000278B7
		[NullableContext(2)]
		public FCameraShakeDuration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000296C1 File Offset: 0x000278C1
		public FCameraShakeDuration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000296CC File Offset: 0x000278CC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraShakeDuration(Pointer, false, true);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000296D6 File Offset: 0x000278D6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraShakeDuration(Pointer, MemoryOwner);
		}

		// Token: 0x04000914 RID: 2324
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraShakeDuration";

		// Token: 0x04000915 RID: 2325
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000916 RID: 2326
		internal static int __PropertyOffset_Duration;

		// Token: 0x04000917 RID: 2327
		internal static int __PropertyOffset_Type;
	}
}
