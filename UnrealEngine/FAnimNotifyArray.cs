using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000826 RID: 2086
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNotifyArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimNotifyArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007032 RID: 28722 RVA: 0x000A0EE9 File Offset: 0x0009F0E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNotifyArray._ScriptStructPtr != 0) ? FAnimNotifyArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNotifyArray", ref FAnimNotifyArray._ScriptStructPtr);
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x000A0F10 File Offset: 0x0009F110
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x000A0F53 File Offset: 0x0009F153
		public TArray<FAnimNotifyEventReference> Notifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEventReference> result;
				if ((result = this._Notifies) == null)
				{
					result = (this._Notifies = new TArray<FAnimNotifyEventReference>(base.NativePtr + (IntPtr)FAnimNotifyArray.__PropertyOffset_Notifies, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Notifies.CopyAssign(value);
			}
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x000A0F61 File Offset: 0x0009F161
		public FAnimNotifyArray()
		{
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x000A0F69 File Offset: 0x0009F169
		public FAnimNotifyArray(TArray<FAnimNotifyEventReference> Notifies)
		{
			this.Notifies = Notifies;
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x000A0F78 File Offset: 0x0009F178
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNotifyArray.StaticStruct();
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x000A0F84 File Offset: 0x0009F184
		[NullableContext(2)]
		public FAnimNotifyArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x000A0F8E File Offset: 0x0009F18E
		public FAnimNotifyArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x000A0F99 File Offset: 0x0009F199
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNotifyArray(Pointer, false, true);
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x000A0FA3 File Offset: 0x0009F1A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNotifyArray(Pointer, MemoryOwner);
		}

		// Token: 0x040035E0 RID: 13792
		public const string __ObjectPath = "/Script/Engine.AnimNotifyArray";

		// Token: 0x040035E1 RID: 13793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035E2 RID: 13794
		internal static int __PropertyOffset_Notifies;

		// Token: 0x040035E3 RID: 13795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEventReference> _Notifies;
	}
}
