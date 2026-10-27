using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B09 RID: 6921
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGIPostProcessCustomData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroGIPostProcessCustomData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019EB0 RID: 106160 RVA: 0x00264152 File Offset: 0x00262352
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGIPostProcessCustomData._ScriptStructPtr != 0) ? FKuroGIPostProcessCustomData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGIPostProcessCustomData", ref FKuroGIPostProcessCustomData._ScriptStructPtr);
		}

		// Token: 0x170067DC RID: 26588
		// (get) Token: 0x06019EB1 RID: 106161 RVA: 0x00264178 File Offset: 0x00262378
		// (set) Token: 0x06019EB2 RID: 106162 RVA: 0x002641BB File Offset: 0x002623BB
		public TMap<FName, FKuroGICustomTag> CustomTags
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroGICustomTag> result;
				if ((result = this._CustomTags) == null)
				{
					result = (this._CustomTags = new TMap<FName, FKuroGICustomTag>(base.NativePtr + (IntPtr)FKuroGIPostProcessCustomData.__PropertyOffset_CustomTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomTags.CopyAssign(value);
			}
		}

		// Token: 0x06019EB3 RID: 106163 RVA: 0x002641C9 File Offset: 0x002623C9
		public FKuroGIPostProcessCustomData()
		{
		}

		// Token: 0x06019EB4 RID: 106164 RVA: 0x002641D1 File Offset: 0x002623D1
		public FKuroGIPostProcessCustomData(TMap<FName, FKuroGICustomTag> CustomTags)
		{
			this.CustomTags = CustomTags;
		}

		// Token: 0x06019EB5 RID: 106165 RVA: 0x002641E0 File Offset: 0x002623E0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGIPostProcessCustomData.StaticStruct();
		}

		// Token: 0x06019EB6 RID: 106166 RVA: 0x002641EC File Offset: 0x002623EC
		[NullableContext(2)]
		public FKuroGIPostProcessCustomData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019EB7 RID: 106167 RVA: 0x002641F6 File Offset: 0x002623F6
		public FKuroGIPostProcessCustomData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019EB8 RID: 106168 RVA: 0x00264201 File Offset: 0x00262401
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGIPostProcessCustomData(Pointer, false, true);
		}

		// Token: 0x06019EB9 RID: 106169 RVA: 0x0026420B File Offset: 0x0026240B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGIPostProcessCustomData(Pointer, MemoryOwner);
		}

		// Token: 0x0400E164 RID: 57700
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGIPostProcessCustomData";

		// Token: 0x0400E165 RID: 57701
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E166 RID: 57702
		internal static int __PropertyOffset_CustomTags;

		// Token: 0x0400E167 RID: 57703
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroGICustomTag> _CustomTags;
	}
}
