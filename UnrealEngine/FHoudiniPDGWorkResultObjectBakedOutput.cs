using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014FF RID: 5375
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniPDGWorkResultObjectBakedOutput")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FHoudiniPDGWorkResultObjectBakedOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060137C2 RID: 79810 RVA: 0x001CA5A1 File Offset: 0x001C87A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniPDGWorkResultObjectBakedOutput._ScriptStructPtr != 0) ? FHoudiniPDGWorkResultObjectBakedOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniPDGWorkResultObjectBakedOutput", ref FHoudiniPDGWorkResultObjectBakedOutput._ScriptStructPtr);
		}

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x060137C3 RID: 79811 RVA: 0x001CA5C8 File Offset: 0x001C87C8
		// (set) Token: 0x060137C4 RID: 79812 RVA: 0x001CA60B File Offset: 0x001C880B
		public TArray<FHoudiniBakedOutput> BakedOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHoudiniBakedOutput> result;
				if ((result = this._BakedOutputs) == null)
				{
					result = (this._BakedOutputs = new TArray<FHoudiniBakedOutput>(base.NativePtr + (IntPtr)FHoudiniPDGWorkResultObjectBakedOutput.__PropertyOffset_BakedOutputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BakedOutputs.CopyAssign(value);
			}
		}

		// Token: 0x060137C5 RID: 79813 RVA: 0x001CA619 File Offset: 0x001C8819
		public FHoudiniPDGWorkResultObjectBakedOutput()
		{
		}

		// Token: 0x060137C6 RID: 79814 RVA: 0x001CA621 File Offset: 0x001C8821
		public FHoudiniPDGWorkResultObjectBakedOutput(TArray<FHoudiniBakedOutput> BakedOutputs)
		{
			this.BakedOutputs = BakedOutputs;
		}

		// Token: 0x060137C7 RID: 79815 RVA: 0x001CA630 File Offset: 0x001C8830
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniPDGWorkResultObjectBakedOutput.StaticStruct();
		}

		// Token: 0x060137C8 RID: 79816 RVA: 0x001CA63C File Offset: 0x001C883C
		[NullableContext(2)]
		public FHoudiniPDGWorkResultObjectBakedOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060137C9 RID: 79817 RVA: 0x001CA646 File Offset: 0x001C8846
		public FHoudiniPDGWorkResultObjectBakedOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060137CA RID: 79818 RVA: 0x001CA651 File Offset: 0x001C8851
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniPDGWorkResultObjectBakedOutput(Pointer, false, true);
		}

		// Token: 0x060137CB RID: 79819 RVA: 0x001CA65B File Offset: 0x001C885B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniPDGWorkResultObjectBakedOutput(Pointer, MemoryOwner);
		}

		// Token: 0x0400A88B RID: 43147
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniPDGWorkResultObjectBakedOutput";

		// Token: 0x0400A88C RID: 43148
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A88D RID: 43149
		internal static int __PropertyOffset_BakedOutputs;

		// Token: 0x0400A88E RID: 43150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHoudiniBakedOutput> _BakedOutputs;
	}
}
