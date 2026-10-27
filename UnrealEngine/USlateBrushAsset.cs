using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001117 RID: 4375
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SlateBrushAsset")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class USlateBrushAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FFD8 RID: 65496 RVA: 0x00178CF2 File Offset: 0x00176EF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateBrushAsset._ClassPtr;
		}

		// Token: 0x0600FFD9 RID: 65497 RVA: 0x00178D00 File Offset: 0x00176F00
		public USlateBrushAsset() : this(BuiltinUtils.AllocNativeUObject(USlateBrushAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FFDA RID: 65498 RVA: 0x00178D28 File Offset: 0x00176F28
		public USlateBrushAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateBrushAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600FFDB RID: 65499 RVA: 0x00178D5C File Offset: 0x00176F5C
		// (set) Token: 0x0600FFDC RID: 65500 RVA: 0x00178D95 File Offset: 0x00176F95
		public FSlateBrush Brush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Brush) == null)
				{
					result = (this._Brush = new FSlateBrush(base.NativePtr + (IntPtr)USlateBrushAsset.__PropertyOffset_Brush, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)USlateBrushAsset.__PropertyOffset_Brush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600FFDD RID: 65501 RVA: 0x00178DB6 File Offset: 0x00176FB6
		static USlateBrushAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SlateBrushAsset");
		}

		// Token: 0x0600FFDE RID: 65502 RVA: 0x00178DC4 File Offset: 0x00176FC4
		protected USlateBrushAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400897C RID: 35196
		public new const string __ObjectPath = "/Script/Engine.SlateBrushAsset";

		// Token: 0x0400897D RID: 35197
		private static IntPtr _ClassPtr;

		// Token: 0x0400897E RID: 35198
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400897F RID: 35199
		internal static int __PropertyOffset_Brush;

		// Token: 0x04008980 RID: 35200
		[Nullable(2)]
		private FSlateBrush _Brush;
	}
}
