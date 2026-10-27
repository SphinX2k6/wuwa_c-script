using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001702 RID: 5890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletPatternDataAsset")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroBulletPatternDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015454 RID: 87124 RVA: 0x001F437A File Offset: 0x001F257A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletPatternDataAsset._ClassPtr;
		}

		// Token: 0x06015455 RID: 87125 RVA: 0x001F4388 File Offset: 0x001F2588
		public UKuroBulletPatternDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletPatternDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015456 RID: 87126 RVA: 0x001F43B0 File Offset: 0x001F25B0
		public UKuroBulletPatternDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletPatternDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x06015457 RID: 87127 RVA: 0x001F43E3 File Offset: 0x001F25E3
		// (set) Token: 0x06015458 RID: 87128 RVA: 0x001F43F3 File Offset: 0x001F25F3
		public unsafe EBulletPatternDestroyType DestroyType
		{
			get
			{
				return (EBulletPatternDestroyType)(*(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_DestroyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_DestroyType) = (byte)value;
			}
		}

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x06015459 RID: 87129 RVA: 0x001F4404 File Offset: 0x001F2604
		// (set) Token: 0x0601545A RID: 87130 RVA: 0x001F4414 File Offset: 0x001F2614
		public unsafe float PatternDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_PatternDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_PatternDuration) = value;
			}
		}

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x0601545B RID: 87131 RVA: 0x001F4428 File Offset: 0x001F2628
		// (set) Token: 0x0601545C RID: 87132 RVA: 0x001F4461 File Offset: 0x001F2661
		public TArray<FEmitterNode> EmitterNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEmitterNode> result;
				if ((result = this._EmitterNodes) == null)
				{
					result = (this._EmitterNodes = new TArray<FEmitterNode>(base.NativePtr + (IntPtr)UKuroBulletPatternDataAsset.__PropertyOffset_EmitterNodes, this));
				}
				return result;
			}
			set
			{
				this.EmitterNodes.CopyAssign(value);
			}
		}

		// Token: 0x0601545D RID: 87133 RVA: 0x001F446F File Offset: 0x001F266F
		static UKuroBulletPatternDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletPatternDataAsset");
		}

		// Token: 0x0601545E RID: 87134 RVA: 0x001F447D File Offset: 0x001F267D
		protected UKuroBulletPatternDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B990 RID: 47504
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletPatternDataAsset";

		// Token: 0x0400B991 RID: 47505
		private static IntPtr _ClassPtr;

		// Token: 0x0400B992 RID: 47506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B993 RID: 47507
		internal static int __PropertyOffset_DestroyType;

		// Token: 0x0400B994 RID: 47508
		internal static int __PropertyOffset_PatternDuration;

		// Token: 0x0400B995 RID: 47509
		internal static int __PropertyOffset_EmitterNodes;

		// Token: 0x0400B996 RID: 47510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEmitterNode> _EmitterNodes;
	}
}
