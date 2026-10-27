using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007BA RID: 1978
	[UnrealObjectPath("/Script/Engine.ActorDataLayer")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FActorDataLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060069CC RID: 27084 RVA: 0x00097EA0 File Offset: 0x000960A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorDataLayer._ScriptStructPtr != 0) ? FActorDataLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorDataLayer", ref FActorDataLayer._ScriptStructPtr);
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060069CD RID: 27085 RVA: 0x00097EC4 File Offset: 0x000960C4
		// (set) Token: 0x060069CE RID: 27086 RVA: 0x00097ED8 File Offset: 0x000960D8
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDataLayer.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDataLayer.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x00097EED File Offset: 0x000960ED
		public FActorDataLayer()
		{
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x00097EF5 File Offset: 0x000960F5
		public FActorDataLayer(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x00097F04 File Offset: 0x00096104
		protected override IntPtr GetUStructPtr()
		{
			return FActorDataLayer.StaticStruct();
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x00097F10 File Offset: 0x00096110
		[NullableContext(2)]
		public FActorDataLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x00097F1A File Offset: 0x0009611A
		public FActorDataLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x00097F25 File Offset: 0x00096125
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorDataLayer(Pointer, false, true);
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00097F2F File Offset: 0x0009612F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorDataLayer(Pointer, MemoryOwner);
		}

		// Token: 0x04003300 RID: 13056
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorDataLayer";

		// Token: 0x04003301 RID: 13057
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003302 RID: 13058
		internal static int __PropertyOffset_Name;
	}
}
