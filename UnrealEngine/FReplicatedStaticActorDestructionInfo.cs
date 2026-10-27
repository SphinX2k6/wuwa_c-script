using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001085 RID: 4229
	[UnrealObjectPath("/Script/Engine.ReplicatedStaticActorDestructionInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FReplicatedStaticActorDestructionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F1C7 RID: 61895 RVA: 0x00166CCE File Offset: 0x00164ECE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReplicatedStaticActorDestructionInfo._ScriptStructPtr != 0) ? FReplicatedStaticActorDestructionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ReplicatedStaticActorDestructionInfo", ref FReplicatedStaticActorDestructionInfo._ScriptStructPtr);
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x00166CF2 File Offset: 0x00164EF2
		// (set) Token: 0x0600F1C9 RID: 61897 RVA: 0x00166D06 File Offset: 0x00164F06
		public unsafe UClassStackOnlyPtr ObjClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReplicatedStaticActorDestructionInfo.__PropertyOffset_ObjClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReplicatedStaticActorDestructionInfo.__PropertyOffset_ObjClass) = value;
			}
		}

		// Token: 0x0600F1CA RID: 61898 RVA: 0x00166D1B File Offset: 0x00164F1B
		public FReplicatedStaticActorDestructionInfo()
		{
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x00166D23 File Offset: 0x00164F23
		public FReplicatedStaticActorDestructionInfo(UClassStackOnlyPtr ObjClass)
		{
			this.ObjClass = ObjClass;
		}

		// Token: 0x0600F1CC RID: 61900 RVA: 0x00166D32 File Offset: 0x00164F32
		protected override IntPtr GetUStructPtr()
		{
			return FReplicatedStaticActorDestructionInfo.StaticStruct();
		}

		// Token: 0x0600F1CD RID: 61901 RVA: 0x00166D3E File Offset: 0x00164F3E
		[NullableContext(2)]
		public FReplicatedStaticActorDestructionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F1CE RID: 61902 RVA: 0x00166D48 File Offset: 0x00164F48
		public FReplicatedStaticActorDestructionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F1CF RID: 61903 RVA: 0x00166D53 File Offset: 0x00164F53
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReplicatedStaticActorDestructionInfo(Pointer, false, true);
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x00166D5D File Offset: 0x00164F5D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReplicatedStaticActorDestructionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400831B RID: 33563
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ReplicatedStaticActorDestructionInfo";

		// Token: 0x0400831C RID: 33564
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400831D RID: 33565
		internal static int __PropertyOffset_ObjClass;
	}
}
