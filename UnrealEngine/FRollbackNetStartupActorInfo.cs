using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200109B RID: 4251
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RollbackNetStartupActorInfo")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FRollbackNetStartupActorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F2EC RID: 62188 RVA: 0x00168529 File Offset: 0x00166729
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRollbackNetStartupActorInfo._ScriptStructPtr != 0) ? FRollbackNetStartupActorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RollbackNetStartupActorInfo", ref FRollbackNetStartupActorInfo._ScriptStructPtr);
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600F2ED RID: 62189 RVA: 0x0016854D File Offset: 0x0016674D
		// (set) Token: 0x0600F2EE RID: 62190 RVA: 0x00168561 File Offset: 0x00166761
		[Nullable(2)]
		public unsafe UObject Archetype
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FRollbackNetStartupActorInfo.__PropertyOffset_Archetype);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRollbackNetStartupActorInfo.__PropertyOffset_Archetype, value);
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600F2EF RID: 62191 RVA: 0x00168576 File Offset: 0x00166776
		// (set) Token: 0x0600F2F0 RID: 62192 RVA: 0x0016858A File Offset: 0x0016678A
		[Nullable(2)]
		public unsafe ULevel Level
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + FRollbackNetStartupActorInfo.__PropertyOffset_Level);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRollbackNetStartupActorInfo.__PropertyOffset_Level, value);
			}
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600F2F1 RID: 62193 RVA: 0x001685A0 File Offset: 0x001667A0
		// (set) Token: 0x0600F2F2 RID: 62194 RVA: 0x001685E3 File Offset: 0x001667E3
		public TArray<UObject> ObjReferences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ObjReferences) == null)
				{
					result = (this._ObjReferences = new TArray<UObject>(base.NativePtr + (IntPtr)FRollbackNetStartupActorInfo.__PropertyOffset_ObjReferences, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjReferences.CopyAssign(value);
			}
		}

		// Token: 0x0600F2F3 RID: 62195 RVA: 0x001685F1 File Offset: 0x001667F1
		public FRollbackNetStartupActorInfo()
		{
		}

		// Token: 0x0600F2F4 RID: 62196 RVA: 0x001685F9 File Offset: 0x001667F9
		public FRollbackNetStartupActorInfo(UObject Archetype, ULevel Level, TArray<UObject> ObjReferences)
		{
			this.Archetype = Archetype;
			this.Level = Level;
			this.ObjReferences = ObjReferences;
		}

		// Token: 0x0600F2F5 RID: 62197 RVA: 0x00168616 File Offset: 0x00166816
		protected override IntPtr GetUStructPtr()
		{
			return FRollbackNetStartupActorInfo.StaticStruct();
		}

		// Token: 0x0600F2F6 RID: 62198 RVA: 0x00168622 File Offset: 0x00166822
		[NullableContext(2)]
		public FRollbackNetStartupActorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F2F7 RID: 62199 RVA: 0x0016862C File Offset: 0x0016682C
		public FRollbackNetStartupActorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x00168637 File Offset: 0x00166837
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRollbackNetStartupActorInfo(Pointer, false, true);
		}

		// Token: 0x0600F2F9 RID: 62201 RVA: 0x00168641 File Offset: 0x00166841
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRollbackNetStartupActorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040083C4 RID: 33732
		public const string __ObjectPath = "/Script/Engine.RollbackNetStartupActorInfo";

		// Token: 0x040083C5 RID: 33733
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083C6 RID: 33734
		internal static int __PropertyOffset_Archetype;

		// Token: 0x040083C7 RID: 33735
		internal static int __PropertyOffset_Level;

		// Token: 0x040083C8 RID: 33736
		internal static int __PropertyOffset_ObjReferences;

		// Token: 0x040083C9 RID: 33737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjReferences;
	}
}
