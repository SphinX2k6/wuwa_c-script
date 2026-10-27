using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000991 RID: 2449
	[UnrealObjectPath("/Script/Engine.DamageEvent")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDamageEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008A47 RID: 35399 RVA: 0x000C6027 File Offset: 0x000C4227
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageEvent._ScriptStructPtr != 0) ? FDamageEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DamageEvent", ref FDamageEvent._ScriptStructPtr);
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06008A48 RID: 35400 RVA: 0x000C604B File Offset: 0x000C424B
		// (set) Token: 0x06008A49 RID: 35401 RVA: 0x000C605F File Offset: 0x000C425F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UDamageType> DamageTypeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageEvent.__PropertyOffset_DamageTypeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FDamageEvent.__PropertyOffset_DamageTypeClass) = value;
			}
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x000C6074 File Offset: 0x000C4274
		public FDamageEvent()
		{
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x000C607C File Offset: 0x000C427C
		public FDamageEvent([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass)
		{
			this.DamageTypeClass = DamageTypeClass;
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x000C608B File Offset: 0x000C428B
		protected override IntPtr GetUStructPtr()
		{
			return FDamageEvent.StaticStruct();
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x000C6097 File Offset: 0x000C4297
		[NullableContext(2)]
		public FDamageEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x000C60A1 File Offset: 0x000C42A1
		public FDamageEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x000C60AC File Offset: 0x000C42AC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageEvent(Pointer, false, true);
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x000C60B6 File Offset: 0x000C42B6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040041A6 RID: 16806
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DamageEvent";

		// Token: 0x040041A7 RID: 16807
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040041A8 RID: 16808
		internal static int __PropertyOffset_DamageTypeClass;
	}
}
