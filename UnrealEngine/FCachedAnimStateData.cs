using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000902 RID: 2306
	[UnrealObjectPath("/Script/Engine.CachedAnimStateData")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FCachedAnimStateData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E8F RID: 32399 RVA: 0x000B5A08 File Offset: 0x000B3C08
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedAnimStateData._ScriptStructPtr != 0) ? FCachedAnimStateData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedAnimStateData", ref FCachedAnimStateData._ScriptStructPtr);
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x000B5A2C File Offset: 0x000B3C2C
		// (set) Token: 0x06007E91 RID: 32401 RVA: 0x000B5A40 File Offset: 0x000B3C40
		public unsafe FName StateMachineName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimStateData.__PropertyOffset_StateMachineName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimStateData.__PropertyOffset_StateMachineName) = value;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x000B5A55 File Offset: 0x000B3C55
		// (set) Token: 0x06007E93 RID: 32403 RVA: 0x000B5A69 File Offset: 0x000B3C69
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedAnimStateData.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedAnimStateData.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x000B5A7E File Offset: 0x000B3C7E
		public FCachedAnimStateData()
		{
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x000B5A86 File Offset: 0x000B3C86
		public FCachedAnimStateData(FName StateMachineName, FName StateName)
		{
			this.StateMachineName = StateMachineName;
			this.StateName = StateName;
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x000B5A9C File Offset: 0x000B3C9C
		protected override IntPtr GetUStructPtr()
		{
			return FCachedAnimStateData.StaticStruct();
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x000B5AA8 File Offset: 0x000B3CA8
		[NullableContext(2)]
		public FCachedAnimStateData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x000B5AB2 File Offset: 0x000B3CB2
		public FCachedAnimStateData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x000B5ABD File Offset: 0x000B3CBD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedAnimStateData(Pointer, false, true);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x000B5AC7 File Offset: 0x000B3CC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedAnimStateData(Pointer, MemoryOwner);
		}

		// Token: 0x04003CBC RID: 15548
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CachedAnimStateData";

		// Token: 0x04003CBD RID: 15549
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CBE RID: 15550
		internal static int __PropertyOffset_StateMachineName;

		// Token: 0x04003CBF RID: 15551
		internal static int __PropertyOffset_StateName;
	}
}
