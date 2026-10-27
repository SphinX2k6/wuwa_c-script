using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000901 RID: 2305
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CachedAnimStateArray")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCachedAnimStateArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E85 RID: 32389 RVA: 0x000B5945 File Offset: 0x000B3B45
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedAnimStateArray._ScriptStructPtr != 0) ? FCachedAnimStateArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedAnimStateArray", ref FCachedAnimStateArray._ScriptStructPtr);
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x000B596C File Offset: 0x000B3B6C
		// (set) Token: 0x06007E87 RID: 32391 RVA: 0x000B59AF File Offset: 0x000B3BAF
		public TArray<FCachedAnimStateData> States
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedAnimStateData> result;
				if ((result = this._States) == null)
				{
					result = (this._States = new TArray<FCachedAnimStateData>(base.NativePtr + (IntPtr)FCachedAnimStateArray.__PropertyOffset_States, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.States.CopyAssign(value);
			}
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x000B59BD File Offset: 0x000B3BBD
		public FCachedAnimStateArray()
		{
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x000B59C5 File Offset: 0x000B3BC5
		public FCachedAnimStateArray(TArray<FCachedAnimStateData> States)
		{
			this.States = States;
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x000B59D4 File Offset: 0x000B3BD4
		protected override IntPtr GetUStructPtr()
		{
			return FCachedAnimStateArray.StaticStruct();
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x000B59E0 File Offset: 0x000B3BE0
		[NullableContext(2)]
		public FCachedAnimStateArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x000B59EA File Offset: 0x000B3BEA
		public FCachedAnimStateArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x000B59F5 File Offset: 0x000B3BF5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedAnimStateArray(Pointer, false, true);
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x000B59FF File Offset: 0x000B3BFF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedAnimStateArray(Pointer, MemoryOwner);
		}

		// Token: 0x04003CB8 RID: 15544
		public const string __ObjectPath = "/Script/Engine.CachedAnimStateArray";

		// Token: 0x04003CB9 RID: 15545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CBA RID: 15546
		internal static int __PropertyOffset_States;

		// Token: 0x04003CBB RID: 15547
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedAnimStateData> _States;
	}
}
